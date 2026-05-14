using MediatR;
using mendes.Application.Enums;
using mendes.Application.Models;
using mendes.Application.UserProfiles.Commands;
using mendes.Dal;
using mendes.Domain.Aggregates.UserProfileAggregate;


namespace mendes.Application.UserProfiles.CommandHandlers
{
    internal class DeleteUserProfileHandler : IRequestHandler<DeleteUserProfile, OperationResult<UserProfile>>
    {
        private readonly DataContext _ctx;
        public DeleteUserProfileHandler(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<OperationResult<UserProfile>> Handle(DeleteUserProfile request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<UserProfile>();
            var userProfile = _ctx.UserProfiles
                .FirstOrDefault(up => up.UserProfileId == request.UserProfileId);

            if (userProfile == null)
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

            _ctx.UserProfiles.Remove(userProfile);
            await _ctx.SaveChangesAsync();

            result.Payload = userProfile;
            return result;
        }
    }
}
