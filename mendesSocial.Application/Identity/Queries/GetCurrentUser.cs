using MediatR;
using mendes.Application.Identity.Dtos;
using mendes.Application.Models;
using System.Security.Claims;


namespace mendes.Application.Identity.Queries
{
    public class GetCurrentUser : IRequest<OperationResult<IdentityUserProfileDto>>
    {
        public Guid UserProfileId { get; set; }
        public ClaimsPrincipal ClaimsPrincipal { get; set; }
    }
}
