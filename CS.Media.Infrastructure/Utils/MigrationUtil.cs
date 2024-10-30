using CS.Media.Infrastructure.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Serilog;

namespace CS.Media.Infrastructure.Utils
{
    public static class MigrationUtil
    {
        public async static Task ApplyMigrationsAndSeed(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var logger = scope.ServiceProvider.GetRequiredService<ILogger>();
            if (logger == null) throw new Exception("Logger not injected on app start!");

            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            var retryPolicy = Policy.Handle<SqlException>()
                .WaitAndRetryAsync(10, attempt => TimeSpan.FromSeconds(3), (exception, timeSpan, retryCount, context) =>
                {
                    logger.Warning($"Retry {retryCount} failed to connect to the DB. Retrying in {timeSpan.TotalSeconds} seconds.");
                });

            await retryPolicy.ExecuteAsync(async () =>
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    logger.Information("----------------- APPLYING MIGRATIONS -----------------");
                    context.Database.Migrate();
                }
                else
                {
                    logger.Information("----------------- NO MIGRATIONS -----------------");
                }
            });
        }
    }
}
