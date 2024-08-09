using DataLayer.Context;
using DomainLayer.Interface;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly StajProjeContext _context;
        public DbSet<T> entity => _context.Set<T>();
        public GenericRepository(StajProjeContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            this.entity.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            this.entity.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return this.entity.ToList();
        }

        public T GetById(int id)
        {
            var entity = _context.Find<T>(id);
            return entity;
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
