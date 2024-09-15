using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        private static readonly string[] Summaries = new[]
{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        [HttpGet("")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
