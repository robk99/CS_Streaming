using CS.Session.Infrastructure.Abstractions;
using StackExchange.Redis;

namespace CS.Session.Infrastructure.Queue
{
    public class RedisQueueConnection : IRedisConnection
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;

        public RedisQueueConnection(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer;
        }

        public IDatabase GetDatabase() => _connectionMultiplexer.GetDatabase();
    }
}
