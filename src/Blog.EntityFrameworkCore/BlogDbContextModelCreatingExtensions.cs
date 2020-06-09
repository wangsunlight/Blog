using Blog.Domain.Blog;
using Blog.Domain.HotNews;
using Blog.Domain.Wallpaper;
using Blog.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using static Blog.Domain.Shared.BlogDbConsts;

namespace Blog.EntityFrameworkCore
{
    public static class BlogDbContextModelCreatingExtensions
    {
        public static void Configure(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Post>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + DbTableName.Posts);
                b.HasKey(x => x.Id);
                b.Property(x => x.Title).HasMaxLength(200).IsRequired();
                b.Property(x => x.Author).HasMaxLength(10);
                b.Property(x => x.Url).HasMaxLength(100).IsRequired();
                b.Property(x => x.Html).HasColumnType("longtext").IsRequired();
                b.Property(x => x.Markdown).HasColumnType("longtext").IsRequired();
                b.Property(x => x.CategoryId).HasColumnType("int");
                b.Property(x => x.CreationTime).HasColumnType("datetime");
            });

            builder.Entity<Category>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + DbTableName.Categories);
                b.HasKey(x => x.Id);
                b.Property(x => x.CategoryName).HasMaxLength(50).IsRequired();
                b.Property(x => x.DisplayName).HasMaxLength(50).IsRequired();
            });

            builder.Entity<Tag>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + DbTableName.Tags);
                b.HasKey(x => x.Id);
                b.Property(x => x.TagName).HasMaxLength(50).IsRequired();
                b.Property(x => x.DisplayName).HasMaxLength(50).IsRequired();
            });

            builder.Entity<PostTag>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + DbTableName.PostTags);
                b.HasKey(x => x.Id);
                b.Property(x => x.PostId).HasColumnType("int").IsRequired();
                b.Property(x => x.TagId).HasColumnType("int").IsRequired();
            });

            builder.Entity<FriendLink>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + DbTableName.Friendlinks);
                b.HasKey(x => x.Id);
                b.Property(x => x.Title).HasMaxLength(20).IsRequired();
                b.Property(x => x.LinkUrl).HasMaxLength(100).IsRequired();
            });

            builder.Entity<Wallpaper>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + DbTableName.Wallpapers);
                b.HasKey(x => x.Id);
                b.Property(x => x.Id).ValueGeneratedOnAdd();
                b.Property(x => x.Url).HasMaxLength(200).IsRequired();
                b.Property(x => x.Title).HasMaxLength(100).IsRequired();
                b.Property(x => x.Type).HasColumnType("int").IsRequired();
                b.Property(x => x.CreateTime).HasColumnType("datetime").IsRequired();
            });

            builder.Entity<HotNews>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + DbTableName.HotNews);
                b.HasKey(x => x.Id);
                b.Property(x => x.Id).ValueGeneratedOnAdd();
                b.Property(x => x.Title).HasMaxLength(200).IsRequired();
                b.Property(x => x.Url).HasMaxLength(250).IsRequired();
                b.Property(x => x.SourceId).HasColumnType("int").IsRequired();
                b.Property(x => x.CreateTime).HasColumnType("datetime").IsRequired();
            });
        }
    }
}
