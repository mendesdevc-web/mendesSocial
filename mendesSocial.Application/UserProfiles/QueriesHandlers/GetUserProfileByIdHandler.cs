using MediatR;
using mendes.Application.Enums;
using mendes.Application.Models;
using mendes.Application.UserProfiles.Models;
using mendes.Application.UserProfiles.Queries;
using mendes.Dal;
using Microsoft.EntityFrameworkCore;


namespace mendes.Application.UserProfiles.QueriesHandlers
{
    internal class GetUserProfileByIdHandler
        : IRequestHandler<GetUserProfileById, OperationResult<UserProfileDto>>
    {
        private readonly DataContext _ctx;

        public GetUserProfileByIdHandler(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<OperationResult<UserProfileDto>> Handle(GetUserProfileById request,
            CancellationToken cancellationToken)
        {
            var result = new OperationResult<UserProfileDto>();

            var profile = await _ctx.UserProfiles
                .FirstOrDefaultAsync(up => up.UserProfileId == request.UserProfileId,
                    cancellationToken: cancellationToken);

            if (profile is null)
            {
                result.AddError(ErrorCode.NotFound,
                    string.Format(UserProfilesErrorMessages.UserProfileNotFound, request.UserProfileId));
                return result;
            }

            var friendRequests = await _ctx.FriendRequests
                .Where(fr => fr.ReceiverUserProfileId == request.UserProfileId)
                .ToListAsync();

            var friendships = await _ctx.Friendships
                .Where(f => f.FirstFriendUserProfileId == request.UserProfileId
                            || f.SecondFriendUserProfileId == request.UserProfileId)
                .ToListAsync();

            result.Payload = UserProfileDto.FromUserProfile(profile, friendRequests, friendships);
            return result;
        }
    }
}
