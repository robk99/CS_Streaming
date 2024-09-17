using CS.Session.Infrastructure.Dtos;

namespace CS.Session.Infrastructure.Abstractions
{
    public interface IPingService
    {
        public Task<ResponseDto<PingDataDto>> Ping(string ip);
    }
}
