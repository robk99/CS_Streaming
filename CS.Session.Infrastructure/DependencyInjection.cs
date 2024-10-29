using CS.Common.Database.EntityFramework.Interceptors;
using CS.Session.Domain.Abstractions;
using CS.Session.Infrastructure.Abstractions;
using CS.Session.Infrastructure.Database;
using CS.Session.Infrastructure.Database.Repositories;
using CS.Session.Infrastructure.Services.AutoMapper;
using CS.Session.Infrastructure.Services.Cache;
using CS.Session.Infrastructure.Services.Ping;
using CS.Session.Infrastructure.Services.Queue;
using CS.Session.Infrastructure.Session;
using CS.Session.Infrastructure.State;
using Hangfire;
using Hangfire.Redis.StackExchange;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace CS.Session.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("Database"))
            );

            services.AddScoped<ISessionRepository, SessionRepository>();

            services.AddRedisService<RedisQueueService>(configuration, "Queue");
            services.AddRedisService<RedisCacheService>(configuration, "Cache");

            services.AddTransient<IPingService, PingService>();

            services.AddScoped<ISessionStateHandler, SessionStateHandler>();

            services.AddHangfireTaskScheduler(configuration);
            services.AddScoped<IJobService, HangfireJobService>();

            services.AddScoped<ISessionHandler, SessionHandler>();

            return services;
        }

        private static IServiceCollection AddRedisService<T>(this IServiceCollection services, IConfiguration configuration, string connectionKey) where T : class
        {
            services.AddScoped<T>(sp =>
            {
                string connectionString = configuration.GetConnectionString(connectionKey);
                return (T)Activator.CreateInstance(typeof(T), connectionString);
            });

            return services;
        }


        private static IServiceCollection AddHangfireTaskScheduler(this IServiceCollection services, IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("Queue");

            connectionString += ",abortConnect=false";
            var configurationOptions = ConfigurationOptions.Parse(connectionString, true);

            var redisMultiplexer = ConnectionMultiplexer.Connect(connectionString);

            services.AddScoped<JobStateFilter>();

            services.AddHangfire((sp, x) =>
                x.UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseRedisStorage(redisMultiplexer)
                .UseFilter(new JobStateFilter(
                    services.BuildServiceProvider().GetRequiredService<ISessionStateHandler>()))
                );

            services.AddHangfireServer(x =>
            {
                x.WorkerCount = 50; // Set this option based on the machine microservice is spinning on
                x.SchedulePollingInterval = TimeSpan.FromSeconds(1);
            });

            GlobalJobFilters.Filters.Add(new AutomaticRetryAttribute { Attempts = 0 });
            GlobalJobFilters.Filters.Add(new DisableMultipleQueuedItemsFilter());

            return services;
        }
    }
}
