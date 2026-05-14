using Azure;
using MediatR;
using mendes.Application.Enums;
using mendes.Application.Models;
using mendes.Application.UserProfiles.Queries;
using mendes.Dal;
using mendes.Domain.Aggregates.UserProfileAggregate;
using Microsoft.EntityFrameworkCore;

namespace mendes.Application.UserProfiles.QueriesHandlers
{
    internal class GetUserProfileByIdHandler 
        : IRequestHandler<GetUserProfileById, OperationResult<UserProfile>>
    {
        
        private readonly DataContext _ctx;
        public GetUserProfileByIdHandler(DataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<OperationResult<UserProfile>> Handle(GetUserProfileById request, CancellationToken cancellationToken)
        {
            var result =new OperationResult<UserProfile>();
            
            var profile = await _ctx.UserProfiles
                .FirstOrDefaultAsync(up => up.UserProfileId == request.UserProfileId);

            if (profile is null)
            {
                result.IsError = true;
                var error = new Error
                {
                    Code = ErrorCode.NotFound,
                    Message = $"No UserProfile found with Id {request.UserProfileId}"
                };
                result.Errors.Add(error);
                return result;
            }

            result.Payload = profile;
            return result;
        }
    }
}
