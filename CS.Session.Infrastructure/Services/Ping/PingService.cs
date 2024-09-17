using System.Net.NetworkInformation;
using System.Net;
using CS.Session.Infrastructure.Abstractions;
using CS.Session.Infrastructure.Dtos;

namespace CS.Session.Infrastructure.Services.Ping
{
    public class PingService : IPingService
    {
        public async Task<ResponseDto<PingDataDto>> Ping(string ip)
        {
            ResponseDto<PingDataDto> response = new();

            try
            {
                IPAddress ipAddress;

                if (!IPAddress.TryParse(ip, out ipAddress))
                {
                    // TODO: Logging
                    var error = $"Invalid IP Address: {ip}";
                    Console.WriteLine(error);
                    throw new Exception(error);
                }

                System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();

                var startTime = DateTimeOffset.Now.ToUnixTimeSeconds();
         
                var result = await ping.SendPingAsync(ipAddress, 60000);
                if (result.Status == IPStatus.Success)
                {
                    Console.WriteLine($"Ping {ipAddress} successful: {result.Status}");
                    response.Message = result.Status.ToString();
                }
                else
                {
                    Console.WriteLine($"Ping {ipAddress} failed: {result.Status}");
                    response.IsSuccess = false;
                    response.Error = result.Status.ToString();
                }
                var endTime = DateTimeOffset.Now.ToUnixTimeSeconds();

                response.Result = new PingDataDto(){ Start = startTime, End = endTime, PingStatus = result.Status };
            }
            catch (Exception ex)
            {
                response.Error = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }
    }
}
