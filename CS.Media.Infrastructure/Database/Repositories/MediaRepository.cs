using CS.Media.Domain.Abstractions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CS.Media.Infrastructure.Database.Repositories
{
    public class MediaRepository : IMediaRepository
    {
        private readonly AppDbContext _context;

        public MediaRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(Domain.Medias.Media media)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC Medias_Create @Name, @MediaTypeId, @LengthInSeconds",
                new SqlParameter("@Name", media.Name),
                new SqlParameter("@MediaTypeId", media.MediaTypeId),
                new SqlParameter("@LengthInSeconds", media.LengthInSeconds ?? (object)DBNull.Value)
            );
        }

        public  Domain.Medias.Media GetById(int id)
        {
            return _context.Medias.FromSqlRaw("EXEC Medias_GetById @Id",
                new SqlParameter("@Id", id)).FirstOrDefault();
        }
    }
}
