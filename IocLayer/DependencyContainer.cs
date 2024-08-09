using BusinessLayer.Interface;
using BusinessLayer.Models;
using BusinessLayer.Services;
using DataLayer.Context;
using DataLayer.Repository;
using DomainLayer.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IocLayer
{
    public class DependencyContainer : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StajProjeContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));

            //Data
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUserRepository, UserRepository>();

            //Services
            services.AddScoped<IUserService, UserService>();
        }
    }
}
