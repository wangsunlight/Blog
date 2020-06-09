using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Blog.Domain.Shared
{
    [DependsOn(typeof(AbpIdentityDomainSharedModule))]
    public class BlogDomainSharedModule : AbpModule
    {

    }
}