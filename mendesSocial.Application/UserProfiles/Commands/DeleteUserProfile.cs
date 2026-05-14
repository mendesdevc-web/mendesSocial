using MediatR;
using mendes.Application.Models;
using mendes.Domain.Aggregates.UserProfileAggregate;

namespace mendes.Application.UserProfiles.Commands
{
    public class DeleteUserProfile : IRequest<OperationResult<UserProfile>>
    {
        public Guid UserProfileId { get; set; }

    }
}
