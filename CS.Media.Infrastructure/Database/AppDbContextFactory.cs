using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using CS.Common.Database.EntityFramework.Interceptors;

namespace CS.Media.Infrastructure.Database
{
    /// <summary>
    /// Allowing dotnet ef commands to work since 
    /// DbContext is registered in a different project
    /// </summary>
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "CS.Media.API"))
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Database");
            optionsBuilder.UseSqlServer(connectionString, options =>
            {
                options.EnableRetryOnFailure(
                           maxRetryCount: 10,
                           maxRetryDelay: TimeSpan.FromSeconds(10),
                           errorNumbersToAdd: null
                );
            });

            var auditInterceptor = new UpdateAuditMetadataInterceptor();
            optionsBuilder.AddInterceptors(auditInterceptor);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
