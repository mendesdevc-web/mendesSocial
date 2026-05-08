using MediatR;
using mendes.Application.UserProfiles.Queries;
using mendes.Dal;
using mendes.Domain.Aggregates.UserProfileAggregate;
using Microsoft.EntityFrameworkCore;

namespace mendes.Application.UserProfiles.QueriesHandlers
{
    internal class GetUserProfileByIdHandler : IRequestHandler<GetUserProfileById, UserProfile>
    {
        
        private readonly DataContext _ctx;
        public GetUserProfileByIdHandler(DataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<UserProfile> Handle(GetUserProfileById request, CancellationToken cancellationToken)
        {
            return await _ctx.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileId == request.UserProfileId);
        }
    }
}
