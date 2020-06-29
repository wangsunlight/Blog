﻿using Blog.Application.Contracts.Wallpaper;
using Blog.Application.Contracts.Wallpaper.Params;
using Blog.ToolKits.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Application.Wallpaper
{
    public interface IWallpaperService
    {
        /// <summary>
        /// 获取所有壁纸类型
        /// </summary>
        /// <returns></returns>
        Task<ServiceResult<IEnumerable<EnumResponse>>> GetWallpaperTypesAsync();

        /// <summary>
        /// 分页查询壁纸
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ServiceResult<PagedList<WallpaperDto>>> QueryWallpapersAsync(QueryWallpapersInput input);

        /// <summary>
        /// 批量插入壁纸
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ServiceResult<string>> BulkInsertWallpaperAsync(BulkInsertWallpaperInput input);
    }
}