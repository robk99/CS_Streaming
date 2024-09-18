using CS.Session.Domain.Sessions;
using Microsoft.EntityFrameworkCore;

namespace CS.Session.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Domain.Sessions.Session> Sessions { get; set; }

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

            for (int i = 1; i < 21; i++)
            {
                var mediaId = rnd.Next(1, 4);
                var userId = rnd.Next(1, 11);

                var startDate = DateTime.Now.AddMinutes(-rnd.Next(200, 300));
                var endDate = startDate.AddMinutes(rnd.Next(1, 200));

                modelBuilder.Entity<Domain.Sessions.Session>().HasData(new Domain.Sessions.Session()
                {
                    Id = i,
                    MediaId = mediaId,
                    UserId = userId,
                    State = SessionState.CLOSED,
                    StartTime = startDate,
                    EndTime = endDate
                });
            }
        }
    }
}
