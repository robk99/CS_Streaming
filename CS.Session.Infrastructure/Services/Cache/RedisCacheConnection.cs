using CS.Session.Infrastructure.Abstractions;
using StackExchange.Redis;

namespace CS.Session.Infrastructure.Services.Cache
{
    public class RedisCacheConnection : IRedisConnection
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;

        public RedisCacheConnection(string connectionString)
        {
            _connectionMultiplexer = ConnectionMultiplexer.Connect(connectionString);
        }

        public IDatabase GetDatabase() => _connectionMultiplexer.GetDatabase();
        public async Task Dispose() => await _connectionMultiplexer.DisposeAsync();
    }
}
