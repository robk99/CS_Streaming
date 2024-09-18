using CS.Session.Domain.Sessions;
using System.Text.Json.Serialization;

namespace CS.Session.Infrastructure.Dtos
{
    public class BaseSessionDto
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SessionState State { get; set; }
        public string UserIP { get; set; }
    }

    public class SessionDto
    {
        public SessionState State { get; set; }

        public long LastPingTimestamp { get; set; }
        public string Id { get; set; }

    }
}
