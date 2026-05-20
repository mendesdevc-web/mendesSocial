using MediatR;
using mendes.Application.Models;


namespace mendes.Application.Identity.Commands
{
    public class LoginCommand : IRequest<OperationResult<string>>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
