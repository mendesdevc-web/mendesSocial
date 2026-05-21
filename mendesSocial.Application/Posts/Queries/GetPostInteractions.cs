using MediatR;
using mendes.Application.Models;
using mendes.Domain.Aggregates.PostAggregate;

namespace mendes.Application.Posts.Queries
{
    public class GetPostInteractions : IRequest<OperationResult<List<PostInteraction>>>
    {
        public Guid PostId { get; set; }
    }
}
