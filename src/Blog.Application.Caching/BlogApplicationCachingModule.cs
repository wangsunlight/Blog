using Blog.Domain;
using Blog.Domain.Configurations;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace Blog.Application.Caching
{
    [DependsOn(
        typeof(AbpCachingModule),
        typeof(BlogDomainModule)
    )]
    public class BlogApplicationCachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = AppSettings.Caching.RedisConnectionString;
            });

            var csredis = new CSRedis.CSRedisClient(AppSettings.Caching.RedisConnectionString);
            RedisHelper.Initialization(csredis);

            context.Services.AddSingleton<IDistributedCache>(new CSRedisCache(RedisHelper.Instance));
        }
    }
}