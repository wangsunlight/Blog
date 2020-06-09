using Blog.Domain.Blog;
using Blog.Domain.Blog.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Repositories.Blog
{
    /// <summary>
    /// TagRepository
    /// </summary>
    public class TagRepository : EfCoreRepository<BlogDbContext, Tag, int>, ITagRepository
    {
        public TagRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="tags"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<Tag> tags)
        {
            await DbContext.Set<Tag>().AddRangeAsync(tags);
            await DbContext.SaveChangesAsync();
        }
    }
}