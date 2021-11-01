using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Security.Authentication;

namespace SPCS.Saude.API
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
                    webBuilder.UseKestrel((context, serverOptions) =>
                    {
                        var teste = serverOptions.Configure(context.Configuration.GetSection("Kestrel"))
                            .Endpoint("HTTPS", listenOptions =>
                            {
                                listenOptions.HttpsOptions.SslProtocols = SslProtocols.Tls12;
                            });
                    });
                    webBuilder.UseStartup<Startup>();
                });

    }
}
