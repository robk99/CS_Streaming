using CS.Session.Domain.Session;

namespace CS.Session.Infrastructure.Dtos
{
    public class SessionDto
    {
        public SessionState State { get; set; }
        public long LastPingTimestamp { get; set; }
        public string UserIP { get; set; }
    }
}
