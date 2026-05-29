using MediatR;
using mendes.Application.Models;
using mendes.Domain.Aggregates.PostAggregate;


namespace mendes.Application.Posts.Commands
{
    public class RemoveCommentFromPost : IRequest<OperationResult<PostComment>>
    {
        public Guid UserProfileId { get; set; }
        public Guid PostId { get; set; }
        public Guid CommentId { get; set; }
    }
}
