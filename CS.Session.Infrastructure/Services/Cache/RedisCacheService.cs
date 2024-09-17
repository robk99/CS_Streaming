using CS.Session.Infrastructure.Services.Queue;
using CS.Session.Infrastructure.Services.Redis;

namespace CS.Session.Infrastructure.Services.Cache
{
    public class RedisCacheService : RedisService
    {
        public RedisCacheService(string connectionString)
        {
            _redisConnection = new RedisQueueConnection(connectionString);
            _db = _redisConnection.GetDatabase();
        }

    }
}
