using CS.Session.Infrastructure.Services.Cache;
using CS.Session.Infrastructure.Services.Queue;

namespace CS.Session.Tests.Fixtures
{
    public class RedisServiceFixture : IAsyncDisposable
    {
        public RedisCacheService RedisCacheService { get; private set; }
        public RedisQueueService RedisQueueService { get; private set; }


        public RedisServiceFixture()
        {
            // TODO: This shouldn't be hardcoded like this but rather read from secrets / API's appsettings.json
            string cacheConnectionString = "localhost:6379";
            RedisCacheService = new RedisCacheService(cacheConnectionString);

            // TODO: This shouldn't be hardcoded like this but rather read from secrets / API's appsettings.json
            string queueConnectionString = "localhost:6380";
            RedisQueueService = new RedisQueueService(queueConnectionString);
        }

        public async ValueTask DisposeAsync()
        {
            RedisCacheService.DisposeConnection();
            RedisQueueService.DisposeConnection();
        }
    }
}
