using CS.Session.Infrastructure.Cache;
using CS.Session.Infrastructure.Queue;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace CS.Session.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRedisConnection(configuration, "Cache", typeof(RedisCacheConnection));
            services.AddRedisConnection(configuration, "Queue", typeof(RedisQueueConnection));

            services.AddScoped<RedisCacheService>();
            services.AddScoped<RedisQueueService>();

            return services;
        }

        private static IServiceCollection AddRedisConnection(this IServiceCollection services, IConfiguration configuration, string connectionName, Type connectionType)
        {
            string? connectionString = configuration.GetConnectionString(connectionName);
            services.AddSingleton<IConnectionMultiplexer>(sp =>
            {
                var configuration = ConfigurationOptions.Parse(connectionString, true);
                return ConnectionMultiplexer.Connect(configuration);
            });
            services.AddSingleton(connectionType);

            return services;
        }
    }
}
