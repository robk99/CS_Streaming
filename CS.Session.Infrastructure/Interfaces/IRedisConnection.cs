using StackExchange.Redis;

namespace CS.Session.Infrastructure.Interfaces
{
    public interface IRedisConnection
    {
        IDatabase GetDatabase();
    }
}
