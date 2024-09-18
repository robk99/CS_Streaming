namespace CS.Session.Domain.Abstractions
{
    public interface ISessionRepository
    {
        void Create(Sessions.Session session);
        Sessions.Session GetById(long id);
        void Update(Sessions.Session session);
    }
}
