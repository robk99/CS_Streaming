using CS.Session.Infrastructure.Abstractions;

namespace CS.Session.Infrastructure.Cache
{
    public class RedisCacheService : RedisService
    {
        public RedisCacheService(RedisCacheConnection redisConnection)
            :base(redisConnection) {
            _redisConnection = redisConnection;
            _db = _redisConnection.GetDatabase();
        }

    }
}
