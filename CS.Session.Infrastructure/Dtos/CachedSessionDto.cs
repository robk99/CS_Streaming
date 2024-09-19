using CS.Session.Domain.Sessions;
using System.Text.Json.Serialization;

namespace CS.Session.Infrastructure.Dtos
{
    public class SessionDto
    {
        public long Id { get; set; }
        public int MediaId { get; set; }
        public int UserId { get; set; }
        public SessionState State { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }

    public class CachedSessionDto
    {
        public SessionState State { get; set; }

        public long LastPingTimestamp { get; set; }
        public string Id { get; set; }

    }

    public class TestUpdateSessionDto
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SessionState State { get; set; }
        public string UserIP { get; set; }
    }
}
