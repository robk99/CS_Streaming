using CS.Session.Infrastructure.Dtos;
using CS.Session.Infrastructure.Abstractions;
using CS.Session.Infrastructure.Services.Cache;
using CS.Session.Infrastructure.Utils;
using Microsoft.AspNetCore.Mvc;

namespace CS.Session.API.Controllers
{
    [ApiController]
    [Route("api/session")]
    public class PingController : ControllerBase
    {
        private readonly ILogger<PingController> _logger;
        private readonly IPingService _pingService;
        private readonly IJobService _jobService;
        private readonly RedisCacheService _cacheService;

        public PingController(ILogger<PingController> logger, IPingService pingService, RedisCacheService cacheService, IJobService jobService)
        {
            _logger = logger;
            _pingService = pingService;
            _jobService = jobService;
            _cacheService = cacheService;
        }


        [HttpGet("test-ping/{ip}")]
        public async Task<ActionResult<ResponseDto<PingDataDto>>> Ping(string ip)
        {
            return Ok(await _pingService.Ping(ip));
        }


        [HttpPost("test-create")]
        public async Task<ActionResult<ResponseDto>> TestCreate([FromBody] BaseSessionDto session)
        {
            var redisKey = SessionUtil.GetRedisKey(session.UserIP);

            // TODO: if not exist - create new in DB
            // TODO: Get id from DB
            string sessionId = Guid.NewGuid().ToString();

            SessionDto cachedSession = new()
            {
                State = session.State,
                LastPingTimestamp = 0,
                Id = sessionId
            };

            await _cacheService.SetHashAsync(redisKey, cachedSession);

            return Ok(new ResponseDto()
            {
                Message = $"Session {sessionId} created in cache!",
            });
        }




        // TODO: Global Exception handler for controllers - Bubble up errors !




        [HttpPost("update")]
        public async Task<ActionResult<ResponseDto>> Update([FromBody] BaseSessionDto session)
        {
            // In real scenario, get User IP from X-Forwarded-For header
            var redisKey = SessionUtil.GetRedisKey(session.UserIP);
            var cachedSession = await _cacheService.GetHashAsync<SessionDto>(redisKey);

            if (cachedSession == null)
            {
                // TODO: get UserId from JWT claims

                // TODO: if not exist - create new in DB
                // TODO: Get id from DB
                string sessionId = Guid.NewGuid().ToString();

                cachedSession = new()
                {
                    State = session.State,
                    LastPingTimestamp = 0,
                    Id = sessionId
                };

                await _cacheService.SetHashAsync(redisKey, cachedSession);

                _jobService.AddRecurringPingJob(sessionId, session.UserIP);
            }
            else
            {
                cachedSession.State = session.State;
                await _cacheService.SetHashAsync(redisKey, cachedSession);
            }

            return Ok(new ResponseDto()
            {
                Message = $"Session with state {session.State} acknowledged",
            });
        }
    }
}
