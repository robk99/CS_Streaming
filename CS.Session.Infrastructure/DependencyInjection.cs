using CS.Session.Infrastructure.Abstractions;
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
            string? redisCacheConnectionString = configuration.GetConnectionString("Cache");
            services.AddSingleton<IConnectionMultiplexer>(sp =>
            {
                var configuration = ConfigurationOptions.Parse(redisCacheConnectionString, true);
                return ConnectionMultiplexer.Connect(configuration);
            });
            services.AddSingleton<IRedisConnection, RedisCacheConnection>();

            string? redisQueueConnectionString = configuration.GetConnectionString("Queue");
            services.AddSingleton<IConnectionMultiplexer>(sp =>
            {
                var configuration = ConfigurationOptions.Parse(redisQueueConnectionString, true);
                return ConnectionMultiplexer.Connect(configuration);
            });
            services.AddSingleton<IRedisConnection, RedisQueueConnection>();

            services.AddScoped<RedisCacheService>();
            services.AddScoped<RedisQueueService>();


            return services;
        }
    }
}
