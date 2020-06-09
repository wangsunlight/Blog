using Blog.Domain;
using Microsoft.AspNetCore.Builder;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace Blog.Swagger
{
    [DependsOn(typeof(BlogDomainModule))]
    public class BlogSwaggerModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSwagger();
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            context.GetApplicationBuilder().UseSwagger().UseSwaggerUI();
        }
    }
}
