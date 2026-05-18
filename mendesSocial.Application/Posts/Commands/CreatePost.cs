using MediatR;
using mendes.Application.Models;
using mendes.Domain.Aggregates.PostAggregate;

namespace mendes.Application.Posts.Commands
{
    public class CreatePost : IRequest<OperationResult<Post>>
    {
        public Guid UserProfileId { get; set; }
        public string TextContent { get; set; }
    }
}
