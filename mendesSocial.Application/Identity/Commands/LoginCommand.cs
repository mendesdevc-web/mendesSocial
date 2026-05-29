using MediatR;
using mendes.Application.Identity.Dtos;
using mendes.Application.Models;


namespace mendes.Application.Identity.Commands
{
    public class LoginCommand : IRequest<OperationResult<IdentityUserProfileDto>>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
