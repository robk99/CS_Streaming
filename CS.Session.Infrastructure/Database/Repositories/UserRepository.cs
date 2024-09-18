using CS.Session.Domain.Abstractions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CS.Session.Infrastructure.Database.Repositories
{
    public class SessionRepository : ISessionRepository
    {
        private readonly AppDbContext _context;

        public SessionRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(Domain.Sessions.Session session)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC Sessions_Create @MediaId, @UserId, @State, @StartTime, @EndTime",
                new SqlParameter("@MediaId", session.MediaId),
                new SqlParameter("@UserId", session.UserId),
                new SqlParameter("@State", session.State),
                new SqlParameter("@StartTime", session.StartTime),
                new SqlParameter("@EndTime", session.EndTime == null ? DBNull.Value : session.EndTime)
            );
        }

        public Domain.Sessions.Session GetById(long id)
        {
            return _context.Sessions.FromSqlRaw("EXEC Sessions_GetById @Id",
                new SqlParameter("@Id", id)).FirstOrDefault();
        }

        public void Update(Domain.Sessions.Session session)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC Sessions_Update @Id, @State, @EndTime",
                new SqlParameter("@Id", session.Id),
                new SqlParameter("@State", session.State),
                new SqlParameter("@EndTime", session.EndTime == null ? DBNull.Value : session.EndTime)
            );
        }
    }
}
