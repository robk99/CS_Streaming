namespace CS.Session.Domain.Abstractions
{
    public interface ISessionRepository
    {
        Task<long> Create(Sessions.Session session);
        Task<Sessions.Session> GetById(long id);
        Task Update(Sessions.Session session);
    }
}
