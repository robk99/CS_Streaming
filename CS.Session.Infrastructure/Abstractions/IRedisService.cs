namespace CS.Session.Infrastructure.Abstractions
{
    public interface IRedisService
    {
        public Task<string> GetAsync(string key);
        public Task<T> GetHashAsync<T>(string key) where T : class, new();
        public Task SetAsync(string key, string value);
        public Task SetHashAsync<T>(string key, T obj) where T : class;
        public Task DeleteAsync(string key);
    }
}
