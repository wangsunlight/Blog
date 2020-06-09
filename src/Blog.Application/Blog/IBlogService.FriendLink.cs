using Blog.Application.Contracts.Blog;
using Blog.ToolKits.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Application.Blog
{
    public partial interface IBlogService
    {
        /// <summary>
        /// 查询友链列表
        /// </summary>
        /// <returns></returns>
        Task<ServiceResult<IEnumerable<FriendLinkDto>>> QueryFriendLinksAsync();
    }
}