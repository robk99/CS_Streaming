using CS.Session.Domain.Abstractions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CS.Session.Infrastructure.Database.Repositories
{
    public class SessionRepository : ISessionRepository
    {
        private readonly AppDbContext _context;

        public SessionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<long> Create(Domain.Sessions.Session session)
        {
            var procedureName = "Sessions_Create";
            var ouputValue = new SqlParameter("@NewSessionId", SqlDbType.BigInt)
            {
                Direction = ParameterDirection.Output
            };

            var result = await _context.Database.ExecuteSqlRawAsync(
                    $"EXEC {procedureName} @MediaId, @UserId, @State, @StartTime, @EndTime, @NewSessionId OUTPUT;",
                new SqlParameter("@MediaId", session.MediaId),
                new SqlParameter("@UserId", session.UserId),
                new SqlParameter("@State", session.State.ToString()),
                new SqlParameter("@StartTime", session.StartTime),
                new SqlParameter("@EndTime", session.EndTime == null ? DBNull.Value : session.EndTime),
                ouputValue
            );

            if (ouputValue.Value != DBNull.Value && long.TryParse(ouputValue.Value.ToString(), out long sessionId)) return sessionId;
            else throw new InvalidOperationException($"Failed to parse the new ID: ({ouputValue.Value}) from the stored procedure '{procedureName}'. Stored Procedure Result: {result}");
        }

        public async Task<Domain.Sessions.Session> GetById(long id)
        {
            return _context.Sessions.FromSqlRaw("EXEC Sessions_GetById @Id",
                new SqlParameter("@Id", id))
                .AsEnumerable().First();
        }

        public async Task Update(Domain.Sessions.Session session)
        {
            await _context.Database.ExecuteSqlRawAsync(
                "EXEC Sessions_Update @Id, @State, @EndTime",
                new SqlParameter("@Id", session.Id),
                new SqlParameter("@State", session.State.ToString()),
                new SqlParameter("@EndTime", session.EndTime == null ? DBNull.Value : session.EndTime)
            );
        }
    }
}
