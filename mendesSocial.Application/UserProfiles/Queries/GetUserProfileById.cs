using MediatR;
using mendes.Application.Models;
using mendes.Application.UserProfiles.Models;
using mendes.Domain.Aggregates.UserProfileAggregate;


namespace mendes.Application.UserProfiles.Queries
{
    public class GetUserProfileById : IRequest<OperationResult<UserProfileDto>>
    {
        public Guid UserProfileId { get; set; }
    }
}
