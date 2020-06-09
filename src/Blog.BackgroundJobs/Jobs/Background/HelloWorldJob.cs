using log4net;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Blog.BackgroundJobs.Jobs.Background
{
    public class HelloWorldJob : BackgroundService
    {
        private readonly ILog _log;

        public HelloWorldJob()
        {
            _log = LogManager.GetLogger(typeof(HelloWorldJob));
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.CompletedTask;
            //while (!stoppingToken.IsCancellationRequested)
            //{
            //    var msg = $"CurrentTime:{ DateTime.Now}, Hello World!";

            //    Console.WriteLine(msg);

            //    _log.Info(msg);

            //    await Task.Delay(1000, stoppingToken);
            //}
        }
    }
}