using System;
using System.Collections.Generic;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Context;

public partial class StajProjeContext : DbContext
{
    public StajProjeContext()
    {
    }

    public StajProjeContext(DbContextOptions<StajProjeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<Parameter> Parameters { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ELIF\\SQLEXPRESS;Database=StajProje;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Device>(entity =>
        {
            entity.ToTable("DEVICE");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FirstParameterDate).HasColumnType("datetime");
            entity.Property(e => e.LastParameterDate).HasColumnType("datetime");
            entity.Property(e => e.SerialNumber).HasMaxLength(12);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Parameter).WithMany(p => p.Devices)
                .HasForeignKey(d => d.ParameterId)
                .HasConstraintName("FK_DEVICE_PARAMETER");
        });

        modelBuilder.Entity<Parameter>(entity =>
        {
            entity.ToTable("PARAMETER");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("USER");

            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
