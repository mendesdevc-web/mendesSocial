using MediatR;
using mendes.Application.Models;
using mendes.Domain.Aggregates.PostAggregate;

namespace mendes.Application.Posts.Queries
{
    public class GetPostComments : IRequest<OperationResult<List<PostComment>>>
    {
        public Guid PostId { get; set; }
    }
}
