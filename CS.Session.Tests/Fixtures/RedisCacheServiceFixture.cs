using CS.Session.Infrastructure.Cache;
using StackExchange.Redis;

namespace CS.Session.Tests.Fixtures
{
    public class RedisCacheServiceFixture : IDisposable
    {
        public RedisCacheService RedisCacheService { get; private set; }

        public RedisCacheServiceFixture()
        {
            string cacheConnectionString = "localhost:6379";
            var redisCacheConnection = new RedisCacheConnection(ConnectionMultiplexer.Connect(cacheConnectionString));
            RedisCacheService = new RedisCacheService(redisCacheConnection);
        }

        public void Dispose()
        {
        }
    }
}
