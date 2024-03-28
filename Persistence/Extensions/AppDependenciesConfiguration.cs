using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.DataContext;
using Persistence.Repositories;

namespace Persistence.Extensions
{
    /// <summary>
    /// The application services for data access (infrastructure layer) 
    /// </summary>
    public static class AppDependenciesConfiguration
    {
        /// <summary>
        /// method to add the method services (services from the infrastructure layer)
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IServiceCollection AddIdentityServiceConfiguration(this IServiceCollection services, Action<DbContextOptionsBuilder> options) 
        {
             services.AddDbContextPool<RepositoryContext>(options)
                .AddIdentity<User, IdentityRole>(opts =>
            {
                opts.Password.RequireDigit = true;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequiredLength = 10;
                opts.User.RequireUniqueEmail = true;
            })
              .AddEntityFrameworkStores<RepositoryContext>()
              .AddDefaultTokenProviders();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services.AddScoped<IRepositoryManager, RepositoryManager>(); 
        }
    }
}
