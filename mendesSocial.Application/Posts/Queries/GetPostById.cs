using MediatR;
using mendes.Application.Models;


namespace mendes.Application.Posts.Queries
{
    public class GetPostById : IRequest<OperationResult<mendes.Domain.Aggregates.PostAggregate.Post>>
    {
        public Guid PostId { get; set; }
    }
}
