using CS.Media.Domain.Abstractions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CS.Media.Infrastructure.Database.Repositories
{
    public class MediaTypeRepository : IMediaTypeRepository
    {
        private readonly AppDbContext _context;

        public MediaTypeRepository(AppDbContext context)
        {
            _context = context;
        }

        public Domain.Medias.MediaType GetById(int id)
        {
            return _context.MediaTypes.FromSqlRaw("EXEC MediaTypes_GetById @Id",
                new SqlParameter("@Id", id)).FirstOrDefault();
        }
    }
}
