using AutoMapper;
using mendes.Application.Identity.Commands;
using mendes.Application.Identity.Dtos;
using mendesSocial.Api.Contracts.Identity;

namespace mendesSocial.Api.MappingProfiles
{
    public class IdentityMappings : Profile
    {
        public IdentityMappings()
        {
            CreateMap<UserRegistration, RegisterIdentity>();
            CreateMap<Login, LoginCommand>();
            CreateMap<IdentityUserProfileDto, IdentityUserProfile>();
        }
    }
}
