using CS.Session.Domain.Session;
using CS.Session.Infrastructure.Abstractions;
using CS.Session.Infrastructure.Dtos;
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
        }


        [Theory]
        [InlineData("cache")]
        [InlineData("queue")]
        public async Task SetAndGetHash_ShouldReturnSameObject(string serviceType)
        {
            RedisService redisService = GetRedisService(serviceType);

            // Arrange
            string key = "session:1234";
            var obj = new SessionDto
            {
                State = SessionState.PAUSE,
                LastPingTimestamp = 1726428892,
                UserIP = "8.8.8.8"
            };

            // Act
            await redisService.SetHashAsync<SessionDto>(key, obj);
            var retrievedObj = await redisService.GetHashAsync<SessionDto>(key);

            // Assert
            Assert.Equal(obj.State, retrievedObj.State);
            Assert.Equal(obj.LastPingTimestamp, retrievedObj.LastPingTimestamp);
            Assert.Equal(obj.UserIP, retrievedObj.UserIP);
        }

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
    }
}