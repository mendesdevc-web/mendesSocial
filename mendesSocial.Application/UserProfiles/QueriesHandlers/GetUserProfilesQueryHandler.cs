using MediatR;
using mendes.Application.UserProfiles.Queries;
using mendes.Dal;
using mendes.Domain.Aggregates.UserProfileAggregate;
using Microsoft.EntityFrameworkCore;


namespace mendes.Application.UserProfiles.QueriesHandlers
{
    internal class GetUserProfilesQueryHandler : IRequestHandler<GetAllUserProfiles, IEnumerable<UserProfile>>
    {
        private readonly DataContext _ctx;
        public GetUserProfilesQueryHandler(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async  Task<IEnumerable<UserProfile>> Handle(GetAllUserProfiles request, 
            CancellationToken cancellationToken)
        {
            return await _ctx.UserProfiles.ToListAsync();
        }
    }
}
