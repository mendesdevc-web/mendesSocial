using MediatR;
using mendes.Application.Models;
using mendes.Application.UserProfiles.Queries;
using mendes.Dal;
using mendes.Domain.Aggregates.UserProfileAggregate;
using Microsoft.EntityFrameworkCore;


namespace mendes.Application.UserProfiles.QueriesHandlers
{
    internal class GetAllUserProfilesQueryHandler 
        : IRequestHandler<GetAllUserProfiles, OperationResult<IEnumerable<UserProfile>>>
    {
        private readonly DataContext _ctx;
        public GetAllUserProfilesQueryHandler(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<OperationResult<IEnumerable<UserProfile>>> Handle(GetAllUserProfiles request, 
            CancellationToken cancellationToken)
        {
            var result = new OperationResult<IEnumerable<UserProfile>>();

            result.Payload = await _ctx.UserProfiles.ToListAsync();
            return result;
        }
    }
}
