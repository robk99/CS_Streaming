using StackExchange.Redis;

namespace CS.Session.Infrastructure.Utils
{
    public static class RedisUtil
    {
        public static IConnectionMultiplexer GetMultiplexer(string connectionString)
        {
            connectionString += ",abortConnect=false";
            var configurationOptions = ConfigurationOptions.Parse(connectionString, true);

            return ConnectionMultiplexer.Connect(connectionString);
        }
    }
}
