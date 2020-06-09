using Blog.Domain.Blog;
using Blog.Domain.Blog.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Repositories.Blog
{
    /// <summary>
    /// FriendLinkRepository
    /// </summary>
    public class FriendLinkRepository : EfCoreRepository<BlogDbContext, FriendLink, int>, IFriendLinkRepository
    {
        public FriendLinkRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}