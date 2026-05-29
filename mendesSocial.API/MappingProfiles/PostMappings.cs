using AutoMapper;
using mendes.Domain.Aggregates.PostAggregate;
using mendes.Api.Contracts.Post.Responses;
using mendesSocial.Api.Contracts.Post.Responses;
using PostInteraction = mendes.Domain.Aggregates.PostAggregate.PostInteraction;

namespace mendes.Api.MappingProfiles
{
    public class PostMappings : Profile
    {
        public PostMappings()
        {
            CreateMap<Post, PostResponse>();
            CreateMap<PostComment, PostCommentResponse>();
            CreateMap<PostInteraction, mendesSocial.Api.Contracts.Post.Responses.PostInteraction>()
                .ForMember(dest
                    => dest.Type, opt
                    => opt.MapFrom(src
                    => src.InteractionType.ToString()))
                .ForMember(dest => dest.Author, opt
                => opt.MapFrom(src => src.UserProfile));
        }
    }
}
