using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebResume.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();
            logger.LogInformation("Web Resume App Service Started");
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                //.ConfigureAppConfiguration((hostingContext, config) =>
                //{
                //    var settings = config.Build();
                //    config.AddAzureAppConfiguration(settings["https://employeeparser.azconfig.io"]);
                //    //config.AddAzureAppConfiguration(options =>
                //    //{
                //    //    options.Connect("https://employeeparser.azconfig.io")
                //    //      .ConfigureRefresh(refresh =>
                //    //      {
                //    //          refresh.Register("Processing:OptionA", "InvoiceService")
                //    //                .Register("Processing:OptionB", "InvoiceService");
                //    //      });
                //    //});
                //})
                .ConfigureLogging((context, logging) => //Logging configuration
                {
                    logging.ClearProviders();
                    logging.AddConfiguration(context.Configuration.GetSection(""));
                    logging.AddDebug();
                    logging.AddConsole();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
