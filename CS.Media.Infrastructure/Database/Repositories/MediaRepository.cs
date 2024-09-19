using CS.Media.Domain.Abstractions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CS.Media.Infrastructure.Database.Repositories
{
    public class MediaRepository : IMediaRepository
    {
        private readonly AppDbContext _context;

        public MediaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(Domain.Medias.Media media)
        {
            var procedureName = "Medias_Create";
            var ouputValue = new SqlParameter("@NewMediaId", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            var result = await _context.Database.ExecuteSqlRawAsync(
                $"EXEC {procedureName} @Name, @MediaTypeId, @LengthInSeconds, @NewMediaId OUTPUT;",
                new SqlParameter("@Name", media.Name),
                new SqlParameter("@MediaTypeId", media.MediaTypeId),
                new SqlParameter("@LengthInSeconds", media.LengthInSeconds ?? (object)DBNull.Value),
                ouputValue
            );

            if (ouputValue.Value != DBNull.Value && int.TryParse(ouputValue.Value.ToString(), out int mediaId)) return mediaId;
            else throw new InvalidOperationException($"Failed to parse the new ID: ({ouputValue.Value}) from the stored procedure '{procedureName}'. Stored Procedure Result: {result}");
        }

        public async Task<Domain.Medias.Media> GetById(int id)
        {
            return _context.Medias.FromSqlRaw("EXEC Medias_GetById @Id",
                new SqlParameter("@Id", id)).AsEnumerable().First();
        }
    }
}
