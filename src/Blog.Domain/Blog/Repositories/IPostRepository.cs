using Volo.Abp.Domain.Repositories;

namespace Blog.Domain.Blog.Repositories
{
    /// <summary>
    /// IPostRepository
    /// </summary>
    public interface IPostRepository : IRepository<Post, int>
    {
        
    }
}