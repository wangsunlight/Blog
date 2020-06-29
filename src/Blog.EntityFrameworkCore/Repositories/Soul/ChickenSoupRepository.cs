using Blog.Domain.Shared;
using Blog.Domain.Soul;
using Blog.Domain.Soul.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using static Blog.Domain.Shared.BlogDbConsts;

namespace Blog.EntityFrameworkCore.Repositories.Soul
{
    public class ChickenSoupRepository : EfCoreRepository<BlogDbContext, ChickenSoup, Guid>, IChickenSoupRepository
    {
        public ChickenSoupRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        /// <summary>
        /// 获取一条随机数据
        /// </summary>
        /// <returns></returns>
        public async Task<ChickenSoup> GetRandomAsync()
        {
            // TODO:不同数据库使用不同的SQL
            var sql = $"SELECT * FROM {BlogConsts.DbTablePrefix + DbTableName.ChickenSoups} ORDER BY RAND() LIMIT 1";
            return await DbContext.Set<ChickenSoup>().FromSqlRaw(sql).FirstOrDefaultAsync();
        }

        /// <summary>
        /// 批量插入数据
        /// </summary>
        /// <param name="chickenSoups"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<ChickenSoup> chickenSoups)
        {
            await DbContext.Set<ChickenSoup>().AddRangeAsync(chickenSoups);
            await DbContext.SaveChangesAsync();
        }
    }
}