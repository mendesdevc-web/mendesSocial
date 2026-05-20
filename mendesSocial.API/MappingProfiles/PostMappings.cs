using AutoMapper;
using mendes.Domain.Aggregates.PostAggregate;
using mendes.Api.Contracts.Post.Responses;
using mendesSocial.Api.Contracts.Post.Responses;

namespace mendes.Api.MappingProfiles
{
    public class PostMappings : Profile
    {
        public PostMappings()
        {
            CreateMap<Post, PostResponse>();
            CreateMap<PostComment, PostCommentResponse>();

        }
    }
}
