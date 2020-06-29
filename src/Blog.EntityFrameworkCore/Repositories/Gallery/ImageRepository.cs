using Blog.Domain.Gallery;
using Blog.Domain.Gallery.Repositories;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Repositories.Gallery
{
    public class ImageRepository : EfCoreRepository<BlogDbContext, Image, Guid>, IImageRepository
    {
        public ImageRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}