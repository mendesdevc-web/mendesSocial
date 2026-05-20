using AutoMapper;
using MediatR;
using mendes.Application.Enums;
using mendes.Application.Identity.Commands;
using mendes.Application.Models;
using mendes.Application.Options;
using mendes.Dal;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;


namespace mendes.Application.Identity.Handlers
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, OperationResult<string>>
    {
        public Task<OperationResult<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}


