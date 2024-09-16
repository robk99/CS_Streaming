using CS.Session.Infrastructure.Abstractions;

namespace CS.Session.Infrastructure.Queue
{
    public class RedisQueueService: RedisService
    {
        public RedisQueueService(RedisQueueConnection redisConnection)
            : base(redisConnection) {
            _redisConnection = redisConnection;
            _db = _redisConnection.GetDatabase();
        }

    }
}
