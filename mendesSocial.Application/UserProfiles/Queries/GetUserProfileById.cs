using MediatR;
using mendes.Application.Models;
using mendes.Domain.Aggregates.UserProfileAggregate;


namespace mendes.Application.UserProfiles.Queries
{
    public class GetUserProfileById : IRequest<OperationResult<UserProfile>>
    {
        public Guid UserProfileId { get; set; }
    }
}
