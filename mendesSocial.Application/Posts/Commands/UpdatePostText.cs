using MediatR;
using mendes.Application.Models;
using mendes.Domain.Aggregates.PostAggregate;


namespace mendes.Application.Posts.Commands
{
    public class UpdatePostText : IRequest<OperationResult<Post>>
    {
        public string NewText { get; set; }
        public Guid PostId { get; set; }
        public Guid UserProfileId { get; set; }
    }
}
