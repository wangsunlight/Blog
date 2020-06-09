using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Blog.EntityFrameworkCore.DbMigrations.EntityFrameworkCore
{
    public class BlogMigrationsDbContextFactory : IDesignTimeDbContextFactory<BlogMigrationsDbContext>
    {
        public BlogMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BlogMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"));

            return new BlogMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}