namespace CS.Session.Infrastructure.Abstractions
{
    public interface IRedisService
    {
        public Task SetAsync(string key, string value);

        public Task<string> GetAsync(string key);

        public Task SetHashAsync<T>(string key, T obj) where T : class;

        public Task<T> GetHashAsync<T>(string key) where T : class, new();
    }
}
