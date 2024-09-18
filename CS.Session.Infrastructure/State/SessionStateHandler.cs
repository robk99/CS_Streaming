using CS.Session.Domain.Sessions;
using CS.Session.Infrastructure.Abstractions;
using CS.Session.Infrastructure.Services.Cache;
using CS.Session.Infrastructure.Utils;

namespace CS.Session.Infrastructure.State
{
    public class SessionStateHandler : ISessionStateHandler
    {
        private readonly RedisCacheService _cacheService;
        private readonly ISessionHandler _sessionHandler;

        public SessionStateHandler(RedisCacheService cacheService, ISessionHandler sessionHandler)
        {
            _cacheService = cacheService;
            _sessionHandler = sessionHandler;
        }

        public async Task OnStateClosed(string sessionIdString, string userIP, string sessionState)
        {
            if (sessionState != SessionState.CLOSED.ToString()) return;
            if (!long.TryParse(sessionIdString, out long sessionId)) throw new Exception("SessionId is not a valid long number!");

            // You could also return lastPingTimestamp from the Job / JobStateFilter
            // to be more precise
            DateTime lastPingTimestamp = DateTime.Now;

            await _sessionHandler.UpdateSessionState(sessionId, SessionState.CLOSED, lastPingTimestamp);

            var redisKey = SessionUtil.GetRedisKey(userIP);
            await _cacheService.DeleteAsync(redisKey);
        }
    }
}
