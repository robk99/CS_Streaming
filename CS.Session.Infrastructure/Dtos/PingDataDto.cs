using System.Net.NetworkInformation;

namespace CS.Session.Infrastructure.Dtos
{
    public class PingDataDto
    {
        public long Start { get; set; }
        public long End { get; set; }
        public IPStatus PingStatus { get; set; }
    }
}
