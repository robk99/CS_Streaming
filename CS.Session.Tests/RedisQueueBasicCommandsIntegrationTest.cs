using CS.Session.Infrastructure.Dtos;
using CS.Session.Infrastructure.Queue;
using CS.Session.Tests.Fixtures;
using CS.Session.Domain.Session;

namespace CS.Session.Tests
{
    public class RedisQueueBasicCommandsIntegrationTest : IClassFixture<RedisQueueServiceFixture>
    {
        private readonly RedisQueueService _redisService;

        public RedisQueueBasicCommandsIntegrationTest(RedisQueueServiceFixture fixture)
        {
            _redisService = fixture.RedisQueueService;
        }

        [Fact]
        public async Task SetAndGetValue_ShouldReturnSameValue()
        {
            // Arrange
            string key = "test-key";
            string value = "value1";

            // Act
            await _redisService.SetAsync(key, value);
            var retrievedValue = await _redisService.GetAsync(key);

            // Assert
            Assert.Equal(value, retrievedValue);
        }

        [Fact]
        public async Task SetAndGetHash_ShouldReturnSameObject()
        {
            // Arrange
            string key = "session:1234";
            var obj = new SessionDto
            {
                State = SessionState.PAUSE,
                LastPingTimestamp = 1726428892,
                UserIP = "8.8.8.8"
            };

            // Act
            await _redisService.SetHashAsync(key, obj);
            var retrievedObj = await _redisService.GetHashAsync<SessionDto>(key);

            // Assert
            Assert.Equal(obj.State, retrievedObj.State);
            Assert.Equal(obj.LastPingTimestamp, retrievedObj.LastPingTimestamp);
            Assert.Equal(obj.UserIP, retrievedObj.UserIP);
        }
    }
}