using Blog.Domain.Gallery;
using Blog.Domain.Gallery.Repositories;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Repositories.Gallery
{
    public class AlbumRepository : EfCoreRepository<BlogDbContext, Album, Guid>, IAlbumRepository
    {
        public AlbumRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}