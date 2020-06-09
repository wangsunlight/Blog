using Volo.Abp.Domain.Repositories;

namespace Blog.Domain.Blog.Repositories
{
    /// <summary>
    /// ICategoryRepository
    /// </summary>
    public interface ICategoryRepository : IRepository<Category, int>
    {

    }
}