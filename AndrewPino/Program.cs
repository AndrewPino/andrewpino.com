using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AndrewPino
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
//                    webBuilder.ConfigureKestrel(serverOptions =>
//                    {
//                        serverOptions.Limits.MaxConcurrentConnections = 100;
//                        serverOptions.Limits.MaxConcurrentUpgradedConnections = 100;
//                        serverOptions.Limits.MaxRequestBodySize = 10 * 1024;
//                        serverOptions.Limits.MinRequestBodyDataRate =
//                            new MinDataRate(bytesPerSecond: 100, 
//                                gracePeriod: TimeSpan.FromSeconds(10));
//                        serverOptions.Limits.MinResponseDataRate =
//                            new MinDataRate(bytesPerSecond: 100, 
//                                gracePeriod: TimeSpan.FromSeconds(10));
//                        serverOptions.Listen(IPAddress.Loopback, 9000);
//                        serverOptions.Listen(IPAddress.Loopback, 9001, 
//                            listenOptions =>
//                            {
//                                listenOptions.UseHttps("cert/andrewpino.com.crt", 
//                                    "Password");
//                            });
//                        serverOptions.ConfigureHttpsDefaults(listenOptions =>
//                        {
//                            listenOptions.SslProtocols = SslProtocols.Tls12;
//                        });
//                        serverOptions.Limits.KeepAliveTimeout = 
//                            TimeSpan.FromMinutes(2);
//                        serverOptions.Limits.RequestHeadersTimeout = 
//                            TimeSpan.FromMinutes(1);
//                    });
                });
    }
}