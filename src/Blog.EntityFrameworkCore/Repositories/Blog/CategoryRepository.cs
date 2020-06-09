using Blog.Domain.Blog;
using Blog.Domain.Blog.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
namespace Blog.EntityFrameworkCore.Repositories.Blog
{
    /// <summary>
    /// CategoryRepository
    /// </summary>
    public class CategoryRepository : EfCoreRepository<BlogDbContext, Category, int>, ICategoryRepository
    {
        public CategoryRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}