using MediatR;
using mendes.Application.Enums;
using mendes.Application.Identity.Commands;
using mendes.Application.Models;
using mendes.Application.Options;
using mendes.Dal;
using mendes.Domain.Aggregates.UserProfileAggregate;
using mendes.Domain.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;


namespace mendes.Application.Identity.Handlers
{
    public class RegisterIdentityHandler : IRequestHandler<RegisterIdentity, OperationResult<string>>
    {
        public Task<OperationResult<string>> Handle(RegisterIdentity request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
