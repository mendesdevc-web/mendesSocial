using AutoMapper;
using mendes.Api.Contracts.UserProfile.Requests;
using mendes.Application.UserProfiles.Commands;
using mendes.Domain.Aggregates.UserProfileAggregate;
using mendes.Api.Contracts.UserProfile.Responses;

namespace mendes.Api.MappingProfiles
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
