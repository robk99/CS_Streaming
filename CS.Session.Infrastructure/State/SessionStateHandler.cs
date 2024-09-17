using CS.Session.Domain.Session;
using CS.Session.Infrastructure.Abstractions;
using CS.Session.Infrastructure.Services.Cache;
using CS.Session.Infrastructure.Utils;

namespace CS.Session.Infrastructure.State
{
    public class SessionStateHandler : ISessionStateHandler
    {
        private readonly RedisCacheService _cacheService;
        public SessionStateHandler(RedisCacheService cacheService)
        {
            _cacheService = cacheService;
        }

        public async Task OnStateClosed(string userIP, string sessionState)
        {
            if (sessionState != SessionState.CLOSED.ToString()) return;

            var redisKey = SessionUtil.GetRedisKey(userIP);
            await _cacheService.DeleteAsync(redisKey);
            // TODO: PUT Session.CLOSED to DB
        }
    }
}
