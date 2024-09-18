using CS.Session.Infrastructure.Dtos;
using CS.Session.Infrastructure.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CS.Session.API.Controllers
{
    [ApiController]
    [Route("api/session")]
    public class SessionController : ControllerBase
    {
        private readonly ILogger<SessionController> _logger;
        private readonly IPingService _pingService;
        private readonly ISessionHandler _sessionHandler;

        public SessionController(ILogger<SessionController> logger, IPingService pingService, ISessionHandler sessionHandler)
        {
            _logger = logger;
            _pingService = pingService;
            _sessionHandler = sessionHandler;
        }

        /// <summary>
        /// Simple PING test
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        [HttpGet("test-ping/{ip}")]
        public async Task<ActionResult<ResponseDto<PingDataDto>>> Ping(string ip)
        {
            return Ok(await _pingService.Ping(ip));
        }


        /// <summary>
        /// This method to mock the creation/update of a session state
        /// (mocks the call: Client --> APIGateway --> SessionService)
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        [HttpPost("test-update")]
        public async Task<ActionResult<ResponseDto>> TestUpdate([FromBody] TestUpdateSessionDto session)
        {
            await _sessionHandler.TestUpdateSession(session);

            return Ok(new ResponseDto()
            {
                Message = $"Session with state {session.State} acknowledged",
            });
        }
    }
}
