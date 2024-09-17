using CS.Session.Infrastructure.Services.Redis;

namespace CS.Session.Infrastructure.Services.Queue
{
    public class RedisQueueService : RedisService
    {
        public RedisQueueService(string connectionString)
        {
            _redisConnection = new RedisQueueConnection(connectionString);
            _db = _redisConnection.GetDatabase();
        }
    }
}
