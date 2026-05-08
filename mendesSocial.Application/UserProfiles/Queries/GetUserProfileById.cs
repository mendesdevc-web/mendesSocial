using MediatR;
using mendes.Domain.Aggregates.UserProfileAggregate;


namespace mendes.Application.UserProfiles.Queries
{
    public class GetUserProfileById : IRequest<UserProfile>
    {
        public Guid UserProfileId { get; set; }
    }
}
