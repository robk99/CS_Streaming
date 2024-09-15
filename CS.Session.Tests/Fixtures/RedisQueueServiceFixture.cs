using CS.Session.Infrastructure.Queue;
using StackExchange.Redis;

namespace CS.Session.Tests.Fixtures
{
    public class RedisQueueServiceFixture : IDisposable
    {
        public RedisQueueService RedisQueueService { get; private set; }

        public RedisQueueServiceFixture()
        {
            string queueConnectionString = "localhost:6380";
            var redisQueueConnection = new RedisQueueConnection(ConnectionMultiplexer.Connect(queueConnectionString));
            RedisQueueService = new RedisQueueService(redisQueueConnection);
        }

        public void Dispose()
        {
        }
    }
}
