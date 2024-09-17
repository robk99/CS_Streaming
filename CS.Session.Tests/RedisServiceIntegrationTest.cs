using CS.Session.Domain.Session;
using CS.Session.Infrastructure.Dtos;
using CS.Session.Infrastructure.Services.Redis;
using CS.Session.Infrastructure.Utils;
using CS.Session.Tests.Fixtures;

namespace CS.Session.Tests
{
    public class RedisServiceIntegrationTest : IClassFixture<RedisServiceFixture>
    {
        private readonly RedisServiceFixture _fixture;

        public RedisServiceIntegrationTest(RedisServiceFixture fixture)
        {
            _fixture = fixture;
        }

        #region STRINGS
        [Theory]
        [InlineData("cache")]
        [InlineData("queue")]
        public async Task SetAndGetValue_ShouldReturnSameValue(string serviceType)
        {
            RedisService redisService = GetRedisService(serviceType);

            // Arrange
            string key = "test-key";
            string value = "value1";

            // Act
            await redisService.SetAsync(key, value);
            var retrievedValue = await redisService.GetAsync(key);

            // Assert
            Assert.Equal(value, retrievedValue);

            // Clean up (delete the key)
            await redisService.DeleteAsync(key);
        }

        [Theory]
        [InlineData("cache")]
        [InlineData("queue")]
        public async Task SetAndDeleteValue_ShouldDeleteValue(string serviceType)
        {
            // Arrange
            RedisService redisService = GetRedisService(serviceType);
            string key = "test-key-1";
            string value = "value1";

            // Act
            await redisService.SetAsync(key, value);
            await redisService.DeleteAsync(key);
            var retrievedValue = await redisService.GetAsync(key);

            // Assert
            Assert.Null(retrievedValue);
        }
        #endregion

        #region HASHES
        [Theory]
        [InlineData("cache")]
        [InlineData("queue")]
        public async Task SetAndGetHash_ShouldReturnSameObject(string serviceType)
        {
            RedisService redisService = GetRedisService(serviceType);

            // Arrange
            string key = SessionUtil.GetRedisKey("8.8.8.8");
            var obj = new SessionDto
            {
                State = SessionState.PAUSE,
                LastPingTimestamp = 1726428892,
                Id = "1-2-3"
            };

            // Act
            await redisService.SetHashAsync<SessionDto>(key, obj);
            var retrievedObj = await redisService.GetHashAsync<SessionDto>(key);

            // Assert
            Assert.Equal(obj.State, retrievedObj.State);
            Assert.Equal(obj.LastPingTimestamp, retrievedObj.LastPingTimestamp);
            Assert.Equal(obj.Id, retrievedObj.Id);

            // Clean up (delete the key)
            await redisService.DeleteAsync(key);
        }


        [Theory]
        [InlineData("cache")]
        [InlineData("queue")]
        public async Task SetAndDeleteHash_ShouldDeleteHash(string serviceType)
        {
            // Arrange
            RedisService redisService = GetRedisService(serviceType);
            
            string key = SessionUtil.GetRedisKey("9.9.9.9");
            var obj = new SessionDto
            {
                State = SessionState.PAUSE,
                LastPingTimestamp = 1726428892,
                Id = "2-3-4"
            };

            // Act
            await redisService.SetHashAsync<SessionDto>(key, obj);
            await redisService.DeleteAsync(key);
            var retrievedObj = await redisService.GetHashAsync<SessionDto>(key);

            // Assert
            Assert.Null(retrievedObj);
        }
        #endregion

        #region Helper methods
        private RedisService GetRedisService(string serviceType)
        {
            switch (serviceType)
            {
                case "cache":
                    return _fixture.RedisCacheService;

                case "queue":
                    return _fixture.RedisQueueService;

                default:
                    throw new Exception("serviceType not found");
            }
        }
        #endregion
    }
}