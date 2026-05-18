using MediatR;
using mendes.Application.Models;
using mendes.Domain.Aggregates.PostAggregate;

namespace mendes.Application.Postss.Queries
{
    public class GetAllPosts : IRequest<OperationResult<List<Post>>>
    {
    }
}