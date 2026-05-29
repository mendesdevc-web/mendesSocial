using AutoMapper;
using mendes.Api.Contracts.UserProfile.Requests;
using mendes.Api.Contracts.UserProfile.Responses;
using mendes.Application.UserProfiles.Commands;
using mendes.Domain.Aggregates.UserProfileAggregate;
using mendesSocial.Api.Contracts.Post.Responses;

namespace mendes.Api.MappingProfiles
{
    public class UserProfileMappings : Profile
    {
        public UserProfileMappings()
        {
            CreateMap<UserProfileCreateUpdate, UpdateUserProfileBasicInfo>();
            CreateMap<UserProfile, UserProfileResponse>();
            CreateMap<BasicInfo, BasicInformation>();
            CreateMap<UserProfile, InteractionUser>()
                .ForMember(dest => dest.FullName, opt
                => opt.MapFrom(src
                => src.BasicInfo.FirstName + " " + src.BasicInfo.LastName))
                .ForMember(dest => dest.City, opt
                => opt.MapFrom(src => src.BasicInfo.CurrentCity));
        }
    }
}
