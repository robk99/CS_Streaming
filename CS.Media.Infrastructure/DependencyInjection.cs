using CS.Common.Database.EntityFramework.Interceptors;
using CS.Media.Domain.Abstractions;
using CS.Media.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CS.Media.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(
                 options => options.UseSqlServer(configuration.GetConnectionString("Database"))
            );

            services.AddScoped<IMediaRepository, Database.Repositories.MediaRepository>();
            services.AddScoped<IMediaTypeRepository, Database.Repositories.MediaTypeRepository>();

            return services;
        }
    }
}
