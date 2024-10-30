using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Media.Infrastructure.Utils
{
    public static class LoggingConfigurationUtil
    {
        public static void ConfigureLogging(this IHostBuilder hostBuilder, IConfiguration configuration)
        {
            hostBuilder.UseSerilog((context, loggerConfiguration) =>
            {
                loggerConfiguration
                    .WriteTo.Console()
                    .ReadFrom.Configuration(configuration);
            });
        }
    }
}
