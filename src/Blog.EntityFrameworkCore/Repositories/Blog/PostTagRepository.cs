using Blog.Domain.Blog;
using Blog.Domain.Blog.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Repositories.Blog
{
    /// <summary>
    /// PostTagRepository
    /// </summary>
    public class PostTagRepository : EfCoreRepository<BlogDbContext, PostTag, int>, IPostTagRepository
    {
        public PostTagRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="postTags"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<PostTag> postTags)
        {
            await DbContext.Set<PostTag>().AddRangeAsync(postTags);
            await DbContext.SaveChangesAsync();
        }
    }
}