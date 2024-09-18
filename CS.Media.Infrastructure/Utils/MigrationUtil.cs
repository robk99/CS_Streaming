using CS.Media.Infrastructure.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CS.Media.Infrastructure.Utils
{
    public static class MigrationUtil
    {
        public static void ApplyMigrationsAndSeed(this WebApplication app)
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
        }
    }
}
