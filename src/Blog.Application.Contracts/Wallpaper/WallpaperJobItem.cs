using Blog.Domain.Shared.Enum;

namespace Blog.Application.Contracts.Wallpaper
{
    /// <summary>
    /// 通用的待爬的类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class WallpaperJobItem<T>
    {
        /// <summary>
        /// <see cref="Result"/>
        /// </summary>
        public T Result { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public WallpaperEnum Type { get; set; }
    }
}