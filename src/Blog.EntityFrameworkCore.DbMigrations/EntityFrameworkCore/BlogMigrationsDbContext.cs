using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.DbMigrations.EntityFrameworkCore
{
    public class BlogMigrationsDbContext : AbpDbContext<BlogMigrationsDbContext>
    {
        public BlogMigrationsDbContext(DbContextOptions<BlogMigrationsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configure();
        }
    }
}