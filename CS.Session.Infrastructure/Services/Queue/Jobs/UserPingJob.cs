using CS.Session.Domain.Session;
using CS.Session.Infrastructure.Abstractions;
using CS.Session.Infrastructure.Dtos;
using CS.Session.Infrastructure.Services.Cache;
using CS.Session.Infrastructure.Utils;
using System.Net.NetworkInformation;

namespace CS.Session.Infrastructure.Services.Queue.Jobs
{
    public class UserPingJob
    {
        private readonly RedisCacheService _cacheService;
        private readonly IPingService _pingService;

        public UserPingJob(RedisCacheService cacheService, IPingService pingService)
        {
            _cacheService = cacheService;
            _pingService = pingService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="userIP"></param>
        /// <returns>SessionState as string for Success/TimedOut pings and empty string in all other cases</returns>
        public async Task<string> Execute(string jobId, string userIP)
        {
            Console.WriteLine($"Pinging user IP: {userIP} - Time: {DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff")}");
            var pingResponse = await _pingService.Ping(userIP);

            var redisKey = SessionUtil.GetRedisKey(userIP);
            var cachedSession = await _cacheService.GetHashAsync<SessionDto>(redisKey);
            if (cachedSession == null)
            {
                // TODO: Log
                Console.WriteLine($"{redisKey} not found in cache but PING was still active!");
                return "";
            }

            cachedSession.LastPingTimestamp = pingResponse.Result.End;

            switch (pingResponse.Result.PingStatus)
            {
                case IPStatus.Success:
                    break;

                case IPStatus.TimedOut:
                    // TODO: Edit in DB and save
                    cachedSession.State = SessionState.CLOSED;
                    break;
                
                default:
                    // TODO: Log and set Retry policy to try again
                    return "";
            }

            await _cacheService.SetHashAsync(redisKey, cachedSession);


            return cachedSession.State.ToString();
        }
    }
}
