using CS.Session.Infrastructure.Abstractions;
using StackExchange.Redis;

namespace CS.Session.Infrastructure.Cache
{
    public class RedisCacheConnection : IRedisConnection
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;

        public RedisCacheConnection(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer;
        }

        public IDatabase GetDatabase() => _connectionMultiplexer.GetDatabase();
    }
}
