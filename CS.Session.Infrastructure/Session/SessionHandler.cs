using AutoMapper;
using CS.Session.Domain.Abstractions;
using CS.Session.Domain.Sessions;
using CS.Session.Infrastructure.Abstractions;
using CS.Session.Infrastructure.Dtos;
using CS.Session.Infrastructure.Services.Cache;
using CS.Session.Infrastructure.Utils;

namespace CS.Session.Infrastructure.Session
{
    public class SessionHandler : ISessionHandler
    {
        private readonly ISessionRepository _sessionRepository;
        private readonly IMapper _mapper;
        private readonly IJobService _jobService;
        private readonly RedisCacheService _cacheService;

        public SessionHandler(ISessionRepository sessionRepository, IMapper mapper, RedisCacheService cacheService, IJobService jobService)
        {
            _sessionRepository = sessionRepository;
            _mapper = mapper;
            _jobService = jobService;
            _cacheService = cacheService;
        }

        public async Task<SessionDto> GetSessionById(long id)
        {
            var session = await _sessionRepository.GetById(id);
            return _mapper.Map<SessionDto>(session);
        }

        public async Task<long> CreateSession(SessionDto sessionCreateDto)
        {
            var session = _mapper.Map<Domain.Sessions.Session>(sessionCreateDto);
            return await _sessionRepository.Create(session);
        }

        public async Task UpdateSessionState(long id, SessionState state, DateTime endTime)
        {
            var session = await _sessionRepository.GetById(id);
            if (session == null)
                throw new Exception("Session not found!");

            session.State = state;
            session.EndTime = endTime;
            await _sessionRepository.Update(session);
        }

        public async Task TestUpdateSession(TestUpdateSessionDto sessionUpdateDto)
        {
            // In real scenario, get User IP from X-Forwarded-For header
            var redisKey = SessionUtil.GetRedisKey(sessionUpdateDto.UserIP);
            var cachedSession = await _cacheService.GetHashAsync<CachedSessionDto>(redisKey);

            if (cachedSession == null)
            {
                // TODO: get UserId from JWT claims

                var sessionDto = new SessionDto
                {
                    MediaId = 2,
                    UserId = 1,
                    State = sessionUpdateDto.State,
                    StartTime = DateTime.Now,
                };
                var sessionId = await CreateSession(sessionDto);

                cachedSession = new()
                {
                    State = sessionUpdateDto.State,
                    LastPingTimestamp = 0,
                    Id = sessionId.ToString()
                };

                await _cacheService.SetHashAsync(redisKey, cachedSession);

                _jobService.AddRecurringPingJob(sessionId.ToString(), sessionUpdateDto.UserIP);
            }
            else
            {
                cachedSession.State = sessionUpdateDto.State;
                await _cacheService.SetHashAsync(redisKey, cachedSession);
            }
        }
    }
}
