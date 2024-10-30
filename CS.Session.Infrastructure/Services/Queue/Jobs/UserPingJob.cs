using CS.Session.Domain.Sessions;
using CS.Session.Infrastructure.Abstractions;
using CS.Session.Infrastructure.Dtos;
using CS.Session.Infrastructure.Services.Cache;
using CS.Session.Infrastructure.Utils;
using Serilog;
using System.Net.NetworkInformation;

namespace CS.Session.Infrastructure.Services.Queue.Jobs
{
    public class UserPingJob
    {
        private readonly RedisCacheService _cacheService;
        private readonly IPingService _pingService;
        private readonly ILogger _logger;

        public UserPingJob(RedisCacheService cacheService, IPingService pingService, ILogger logger)
        {
            _cacheService = cacheService;
            _pingService = pingService;
            _logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="userIP"></param>
        /// <returns>SessionState as string for Success/TimedOut pings, throws an error if no Result or Result.PingStatus (retry) 
        /// and returns an empty string in all other cases</returns>
        public async Task<string> Execute(string jobId, string userIP)
        {
            var mesage = $"user IP: {userIP} - job: {jobId} started: {DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff")}";
            _logger.Information($"Pinging {mesage}");
            var pingResponse = await _pingService.Ping(userIP);
            // TODO: Set retry policy to try again
            // If no Result throw an error so the job can be repeated
            if (pingResponse?.Result == null) throw new Exception($"Ping didn't return any result. {mesage}");

            var redisKey = SessionUtil.GetRedisKey(userIP);
            var cachedSession = await _cacheService.GetHashAsync<CachedSessionDto>(redisKey);
            if (cachedSession == null)
            {
                _logger.Error($"{redisKey} not found in cache but PING was still active!");
                return "";
            }

            cachedSession.LastPingTimestamp = pingResponse.Result.End;

            switch (pingResponse.Result.PingStatus)
            {
                case IPStatus.Success:
                    break;

                case IPStatus.TimedOut:
                    cachedSession.State = SessionState.CLOSED;
                    break;

                default:
                    // TODO: Set Retry policy to try again
                    throw new Exception($"PingStatus: {pingResponse.Result.PingStatus}. {mesage}");
            }

            await _cacheService.SetHashAsync(redisKey, cachedSession);

            return cachedSession.State.ToString();
        }
    }
}
