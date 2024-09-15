using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.NetworkInformation;

namespace CS.Session.API.Controllers
{

    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }

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

        public async Task<ResponseDto> Ping(string ip)
        {
            ResponseDto response = new();

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

                var startMessage = $"Ping started at: {DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff")}";
                Console.WriteLine(startMessage);
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
                    response.IsSuccess = false;
                }
                var endMessage = $"Ping ended at: {DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff")}";
                Console.WriteLine(endMessage);

                response.Message = result.Status.ToString();
                response.Result = new { start = startMessage, end = endMessage };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                response.Message = "Exception";
                response.Result = new { exception = ex.Message };
                response.IsSuccess = false;
            }

            return response;
        }
    }
}
