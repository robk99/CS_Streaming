using StackExchange.Redis;

namespace CS.Session.Infrastructure.Abstractions
{
    public interface IRedisConnection
    {
        IDatabase GetDatabase();
        Task Dispose();
    }
}
