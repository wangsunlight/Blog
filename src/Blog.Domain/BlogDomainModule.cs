using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Blog.Domain
{
    [DependsOn(typeof(AbpIdentityDomainModule))]
    public class BlogDomainModule : AbpModule
    {

    }
}
