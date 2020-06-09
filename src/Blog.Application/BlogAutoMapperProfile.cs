using AutoMapper;
using Blog.Application.Contracts.Blog;
using Blog.Domain.Blog;

namespace Blog
{
    public class BlogAutoMapperProfile : Profile
    {
        public BlogAutoMapperProfile()
        {
            CreateMap<Post, PostDto>();

            CreateMap<PostDto, Post>().ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}
