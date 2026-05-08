using AutoMapper;
using mendesSocial.Api.Contracts.UserProfile.Requests;
using mendes.Application.UserProfiles.Commands;
using mendes.Domain.Aggregates.UserProfileAggregate;
using mendesSocial.Api.Contracts.UserProfile.Responses;

namespace mendesSocial.Api.MappingProfiles
{
    public class UserProfileMappings : Profile
    {
        public UserProfileMappings()
        {
            CreateMap<UserProfileCreateUpdate, CreateUserCommand>();
            CreateMap<UserProfileCreateUpdate, UpdateUserProfileBasicInfo>();
            CreateMap<UserProfile, UserProfileResponse>();
            CreateMap<BasicInfo, BasicInformation>();
        }
    }
}
