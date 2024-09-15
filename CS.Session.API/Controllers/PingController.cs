using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.NetworkInformation;

namespace CS.Session.API.Controllers
{
    [ApiController]
    [Route("api/session")]
    public class PingController : ControllerBase
    {
        private readonly ILogger<PingController> _logger;

        public PingController(ILogger<PingController> logger)
        {
            _logger = logger;
        }


        private static readonly HttpClient _httpClient = new HttpClient();

        [HttpGet("Ping/{ip}")]

        public async Task Ping(string ip)
        {
            try
            {
                IPAddress ipAddress;

                if (IPAddress.TryParse(ip, out ipAddress))
                {
                    Console.WriteLine($"IP Address: {ipAddress}");
                }
                else
                {
                    Console.WriteLine("Invalid IP Address");
                }

                Ping ping = new Ping();

                Console.WriteLine($"Ping started at: {DateTime.Now}");
                PingReply result = await ping.SendPingAsync(ipAddress, 5000);
                if (result.Status == IPStatus.Success)
                {
                    Console.WriteLine("Ping successful!");
                    Console.WriteLine($"Response: {result.Status}");
                }
                else
                {
                    Console.WriteLine("Ping failed!");
                    Console.WriteLine($"Response: {result.Status}");
                }
                Console.WriteLine($"Ping ended at: {DateTime.Now}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
