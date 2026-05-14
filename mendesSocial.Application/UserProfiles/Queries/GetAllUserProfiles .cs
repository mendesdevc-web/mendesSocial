using MediatR;
using mendes.Application.Models;
using mendes.Domain.Aggregates.UserProfileAggregate;

namespace mendes.Application.UserProfiles.Queries
{
    public class GetAllUserProfiles : IRequest<OperationResult<IEnumerable<UserProfile>>>
    {

    }
}
