using CS.Session.Infrastructure.Cache;
using CS.Session.Infrastructure.Queue;
using StackExchange.Redis;

namespace CS.Session.Tests.Fixtures
{
    public class RedisServiceFixture : IAsyncDisposable
    {
        private RedisCacheConnection redisCacheConnection;
        private RedisQueueConnection redisQueueConnection;

        public RedisCacheService RedisCacheService { get; private set; }
        public RedisQueueService RedisQueueService { get; private set; }


        public RedisServiceFixture()
        {
            // TODO: This shouldn't be hardcoded like this but rather read from secrets / API's appsettings.json
            string cacheConnectionString = "localhost:6379";
            redisCacheConnection = new RedisCacheConnection(ConnectionMultiplexer.Connect(cacheConnectionString));
            RedisCacheService = new RedisCacheService(redisCacheConnection);

            // TODO: This shouldn't be hardcoded like this but rather read from secrets / API's appsettings.json
            string queueConnectionString = "localhost:6380";
            redisQueueConnection = new RedisQueueConnection(ConnectionMultiplexer.Connect(queueConnectionString));
            RedisQueueService = new RedisQueueService(redisQueueConnection);
        }

        public async ValueTask DisposeAsync()
        {
            await redisCacheConnection.Dispose();
            await redisQueueConnection.Dispose();
        }
    }
}
