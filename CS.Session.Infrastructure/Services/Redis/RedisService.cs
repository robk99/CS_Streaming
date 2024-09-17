using CS.Session.Infrastructure.Abstractions;
using StackExchange.Redis;

namespace CS.Session.Infrastructure.Services.Redis
{
    /// <summary>
    /// TODO: All methods to return a value and handle if Transaction execution failed
    /// </summary>
    public abstract class RedisService : IRedisService
    {
        public IRedisConnection _redisConnection;
        public IDatabase _db;

        #region GET
        public async Task<string> GetAsync(string key)
        {
            return await _db.StringGetAsync(key);
        }

        public async Task<T?> GetHashAsync<T>(string key) where T : class, new()
        {
            var hashEntries = await _db.HashGetAllAsync(key);
            if (hashEntries.Length == 0) return null;

            return HashEntriesToObject<T>(hashEntries);
        }

        #endregion

        #region SET
        public async Task SetAsync(string key, string value)
        {
            await _db.StringSetAsync(key, value);
        }

        public async Task SetHashAsync<T>(string key, T obj) where T : class
        {
            var hashEntries = ObjectToHashEntries(obj);
            await _db.HashSetAsync(key, hashEntries);
        }
        #endregion

        #region DELETE
        public async Task DeleteAsync(string key)
        {
            await _db.KeyDeleteAsync(key);
        }
        #endregion

        #region DISPOSE
        public async void DisposeConnection()
        {
            await _redisConnection.Dispose();
        }
        #endregion

        #region Helper methods
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
        #endregion
    }

}
