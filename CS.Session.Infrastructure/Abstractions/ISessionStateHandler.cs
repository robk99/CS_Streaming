namespace CS.Session.Infrastructure.Abstractions
{
    public interface ISessionStateHandler
    {
        public Task OnStateClosed(string userIP, string sessionState);
    }
}
