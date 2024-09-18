using Microsoft.EntityFrameworkCore;

namespace CS.Media.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Domain.Medias.Media> Medias { get; set; }
        public DbSet<Domain.Medias.MediaType> MediaTypes { get; set; }

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

            var vodMediaType = new Domain.Medias.MediaType()
            {
                Id = 1,
                Name = "VOD",
                LongName = "Video on Demand"
            };
            
            var aodMediaType = new Domain.Medias.MediaType()
            {
                Id = 2,
                Name = "AOD",
                LongName = "Audio on Demand"
            };

            var epgMediaType = new Domain.Medias.MediaType()
            {
                Id = 3,
                Name = "EPG",
                LongName = "Electronic Program Guide"
            };

            modelBuilder.Entity<Domain.Medias.MediaType>().HasData(vodMediaType);
            modelBuilder.Entity<Domain.Medias.MediaType>().HasData(aodMediaType);
            modelBuilder.Entity<Domain.Medias.MediaType>().HasData(epgMediaType);

            var newEPGMedia = new Domain.Medias.Media()
            {
                Id = 1,
                MediaTypeId = 3,
                Name = "EPG",
            };

            modelBuilder.Entity<Domain.Medias.Media>().HasData(newEPGMedia);

            for (int i = 2; i < 12; i++)
            {
                var newMedia = new Domain.Medias.Media()
                {
                    Id = i,
                    MediaTypeId = 1,
                    Name = $"VOD-{i}",
                };
                newMedia.LengthInSeconds = rnd.Next(30, 14401);

                modelBuilder.Entity<Domain.Medias.Media>().HasData(newMedia);
            }

            for (int i = 12; i < 23; i++)
            {
                var newMedia = new Domain.Medias.Media()
                {
                    Id = i,
                    MediaTypeId = 2,
                    Name = $"AOD-{i}",
                };
                newMedia.LengthInSeconds = rnd.Next(30, 3501);

                modelBuilder.Entity<Domain.Medias.Media>().HasData(newMedia);
            }
        }
    }
}
