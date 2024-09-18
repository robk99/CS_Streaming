using CS.Session.Domain.Sessions;
using CS.Session.Infrastructure.Dtos;

namespace CS.Session.Infrastructure.Abstractions
{
    public interface ISessionHandler
    {
        Task<SessionDto> GetSessionById(long id);
        Task<long> CreateSession(SessionDto sessionCreateDto);
        Task UpdateSessionState(long id, SessionState state, DateTime endTime);
        Task TestUpdateSession(TestUpdateSessionDto sessionUpdateDto);
    }
}
