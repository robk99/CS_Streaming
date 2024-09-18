namespace CS.Session.Infrastructure.Abstractions
{
    public interface ISessionStateHandler
    {
        public Task OnStateClosed(string sessionId, string userIP, string sessionState);
    }
}
