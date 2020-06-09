using Blog.Domain.Blog;
using Blog.Domain.Blog.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Repositories.Blog
{
    /// <summary>
    /// PostRepository
    /// </summary>
    public class PostRepository : EfCoreRepository<BlogDbContext, Post, int>, IPostRepository
    {
        public PostRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}