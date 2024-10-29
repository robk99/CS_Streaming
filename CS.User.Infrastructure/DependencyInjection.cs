using CS.Common.Database.EntityFramework.Interceptors;
using CS.User.Domain.Abstractions;
using CS.User.Infrastructure.Database;
using CS.User.Infrastructure.Database.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CS.User.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("Database"))
            );

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
