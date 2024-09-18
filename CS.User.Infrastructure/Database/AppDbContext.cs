using Microsoft.EntityFrameworkCore;

namespace CS.User.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Domain.Users.User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
        }

        /// <summary>
        /// Seed the data - just for test purposes
        /// </summary>
        /// <param name="modelBuilder"></param>
        private void SeedData(ModelBuilder modelBuilder)
        {
            var rnd = new Random();

            for (int i = 1; i < 11; i++)
            {
                modelBuilder.Entity<Domain.Users.User>().HasData(new Domain.Users.User()
                {
                    Id = i,
                    Name = $"John-{i}",
                    Surname = $"Doe-{i}",
                    Email = $"john-{i}.doe-{i}@fakemail12.com"
                });
            }
        }
    }
}
