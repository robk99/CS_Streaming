using CS.Common.Database.EntityFramework.Interceptors;
using CS.Media.Domain.Abstractions;
using CS.Media.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CS.Media.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<UpdateAuditMetadataInterceptor>();
            services.AddDbContext<AppDbContext>((sp, options) =>
                options.UseSqlServer(configuration.GetConnectionString("Database"),
                    sqlServerOptionsAction: sqlOptions =>
                    {
                        sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 10,
                        maxRetryDelay: TimeSpan.FromSeconds(10),
                        errorNumbersToAdd: null);
                    }
                )
                .AddInterceptors(sp.GetRequiredService<UpdateAuditMetadataInterceptor>())
            );

            services.AddScoped<IMediaRepository, Database.Repositories.MediaRepository>();
            services.AddScoped<IMediaTypeRepository, Database.Repositories.MediaTypeRepository>();

            return services;
        }
    }
}
