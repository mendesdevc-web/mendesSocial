using MediatR;
using mendes.Application.Models;
using mendes.Domain.Aggregates.PostAggregate;


namespace mendes.Application.Posts.Queries
{
    public class GetPostById : IRequest<OperationResult<Post>>
    {
        public Guid PostId { get; set; }
    }
}
