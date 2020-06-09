using Hangfire;
using Blog.BackgroundJobs.Jobs.Hangfire;
using Microsoft.Extensions.DependencyInjection;
using System;
using Blog.BackgroundJobs.Jobs.Wallpapers;
using Blog.BackgroundJobs.Jobs.HotNews;

namespace Blog.BackgroundJobs
{
    public static class MeowvBlogBackgroundJobsExtensions
    {
        public static void UseHangfireTest(this IServiceProvider service)
        {
            var job = service.GetService<HangfireTestJob>();

            RecurringJob.AddOrUpdate("定时任务测试", () => job.ExecuteAsync(), CronType.Minute());
        }

        /// <summary>
        /// 图片抓取
        /// </summary>
        /// <param name="service"></param>
        public static void UseWallpaperJob(this IServiceProvider service)
        {
            var job = service.GetService<WallpaperJob>();
            RecurringJob.AddOrUpdate("壁纸数据抓取", () => job.ExecuteAsync(), CronType.Month());
        }

        /// <summary>
        /// 每日热点数据抓取
        /// </summary>
        /// <param name="context"></param>
        public static void UseHotNewsJob(this IServiceProvider service)
        {
            var job = service.GetService<HotNewsJob>();

            RecurringJob.AddOrUpdate("每日热点数据抓取", () => job.ExecuteAsync(), CronType.Month());
        }
    }
}