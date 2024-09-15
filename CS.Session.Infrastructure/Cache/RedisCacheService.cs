using CS.Session.Infrastructure.Abstractions;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Session.Infrastructure.Cache
{
    public class RedisCacheService : IRedisService
    {
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _db;

        public RedisCacheService(string redisConnectionString)
        {
            _redis = ConnectionMultiplexer.Connect(redisConnectionString);
            _db = _redis.GetDatabase();
        }

        // Simple Get/Set
        public async Task SetAsync(string key, string value)
        {
            await _db.StringSetAsync(key, value);
        }

        public async Task<string> GetAsync(string key)
        {
            return await _db.StringGetAsync(key);
        }

        // Hash Get/Set (with object destructuring)
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

        // Helper method: Convert object to hash entries
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

        // Helper method: Convert hash entries to object
        private T HashEntriesToObject<T>(HashEntry[] hashEntries) where T : new()
        {
            var obj = new T();
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                var hashValue = Array.Find(hashEntries, h => h.Name == property.Name).Value;
                property.SetValue(obj, Convert.ChangeType(hashValue.ToString(), property.PropertyType));
            }

            return obj;
        }
    }
}
