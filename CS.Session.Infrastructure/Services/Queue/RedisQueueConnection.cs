using CS.Session.Infrastructure.Abstractions;
using StackExchange.Redis;

namespace CS.Session.Infrastructure.Services.Queue
{
    public class RedisQueueConnection : IRedisConnection
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;

        public RedisQueueConnection(string connectionString)
        {
            _connectionMultiplexer = ConnectionMultiplexer.Connect(connectionString);
        }

        public IDatabase GetDatabase() => _connectionMultiplexer.GetDatabase();
        public async Task Dispose() => await _connectionMultiplexer.DisposeAsync();
    }
}
