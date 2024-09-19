using CS.User.Infrastructure.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Polly;

namespace CS.User.Infrastructure.Utils
{
    public static class MigrationUtil
    {
        public async static Task ApplyMigrationsAndSeed(this WebApplication app)
        {
            var retryPolicy = Policy.Handle<SqlException>()
            .WaitAndRetryAsync(10, attempt => TimeSpan.FromSeconds(3), (exception, timeSpan, retryCount, context) =>
            {
                Console.WriteLine($"Retry {retryCount} failed to connect to the DB. Retrying in {timeSpan.TotalSeconds} seconds.");
            });

            await retryPolicy.ExecuteAsync(async () =>
            {
                using (var scope = app.Services.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                    if (context.Database.GetPendingMigrations().Any())
                    {
                        Console.WriteLine("----------------- APPLYING MIGRATIONS -----------------");
                        context.Database.Migrate();
                    }
                    else
                    {
                        Console.WriteLine("----------------- NO MIGRATIONS -----------------");
                    }
                }
            });
        }
    }
}
