using CS.Session.Infrastructure.Abstractions;
using StackExchange.Redis;

namespace CS.Session.Infrastructure.Queue
{
    public class RedisQueueService: IRedisService
    {
        private readonly RedisQueueConnection _redisConnection;
        private readonly IDatabase _db;

        public RedisQueueService(RedisQueueConnection redisConnection)
        {
            _redisConnection = redisConnection;
            _db = _redisConnection.GetDatabase();
        }

        public async Task SetAsync(string key, string value)
        {
            await _db.StringSetAsync(key, value);
        }

        public async Task<string> GetAsync(string key)
        {
            return await _db.StringGetAsync(key);
        }

        public async Task SetHashAsync<T>(string key, T obj) where T : class
        {
            var hashEntries = ObjectToHashEntries(obj);
            await _db.HashSetAsync(key, hashEntries);
        }

        public async Task<T> GetHashAsync<T>(string key) where T : class, new()
        {
            var hashEntries = await _db.HashGetAllAsync(key);
            return HashEntriesToObject<T>(hashEntries);
        }

        private HashEntry[] ObjectToHashEntries<T>(T obj)
        {
            var properties = typeof(T).GetProperties();
            var hashEntries = new HashEntry[properties.Length];

            for (int i = 0; i < properties.Length; i++)
            {
                var value = properties[i].GetValue(obj)?.ToString() ?? string.Empty;
                hashEntries[i] = new HashEntry(properties[i].Name, value);
            }

            return hashEntries;
        }

        private T HashEntriesToObject<T>(HashEntry[] hashEntries) where T : new()
        {
            var obj = new T();
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                var hashEntry = Array.Find(hashEntries, h => h.Name == property.Name);

                if (hashEntry.Name.HasValue)
                {
                    var value = hashEntry.Value.ToString();
                    if (property.PropertyType.IsEnum)
                    {
                        var enumValue = Enum.Parse(property.PropertyType, value);
                        property.SetValue(obj, enumValue);
                    }
                    else
                    {
                        property.SetValue(obj, Convert.ChangeType(value, property.PropertyType));
                    }
                }
            }

            return obj;
        }
    }
}
