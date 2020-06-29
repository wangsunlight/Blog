using System;
using Volo.Abp.Domain.Repositories;

namespace Blog.Domain.Gallery.Repositories
{
    public interface IAlbumRepository : IRepository<Album, Guid>
    {
    }
}