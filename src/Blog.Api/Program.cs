using Blog.ToolKits.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;
using Winton.Extensions.Configuration.Consul;

namespace Blog.Api
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder(args)
                //.ConfigureAppConfiguration((hostingContext, config) =>
                //{
                //    var env = hostingContext.HostingEnvironment;
                //    hostingContext.Configuration = config.Build();
                //    string consul_url = hostingContext.Configuration["Consul_Url"];
                //    config.AddConsul(
                //                $"{env.ApplicationName}/appsettings.{env.EnvironmentName}.json",
                //                options =>
                //                {
                //                    options.Optional = true;
                //                    options.ReloadOnChange = true;
                //                    options.OnLoadException = exceptionContext => { exceptionContext.Ignore = true; };
                //                    options.ConsulConfigurationOptions = cco => { cco.Address = new Uri(consul_url); };
                //                }
                //                ).AddEnvironmentVariables();

                //    hostingContext.Configuration = config.Build();
                //})
                      .UseLog4Net()
                      .ConfigureWebHostDefaults(builder =>
                      {
                          builder.UseIISIntegration()
                                 .ConfigureKestrel(options =>
                                 {
                                     options.AddServerHeader = false;
                                 })
                                 //.UseUrls("http://*:5001")
                                 .UseStartup<Startup>();
                      }).UseAutofac().Build().RunAsync();
        }
    }
}