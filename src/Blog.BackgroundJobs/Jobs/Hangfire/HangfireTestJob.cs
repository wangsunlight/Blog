using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BackgroundJobs.Jobs.Hangfire
{
    public class HangfireTestJob : IBackgroundJob
    {
        public async Task ExecuteAsync()
        {
            Console.WriteLine("定时任务测试");

            await Task.CompletedTask;
        }
    }
}
