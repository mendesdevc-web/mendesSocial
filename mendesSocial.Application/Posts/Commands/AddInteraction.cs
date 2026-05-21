using MediatR;
using mendes.Application.Models;
using mendes.Domain.Aggregates.PostAggregate;


namespace mendes.Application.Posts.Commands
{
    public class AddInteraction : IRequest<OperationResult<PostInteraction>>
    {
        public Guid PostId { get; set; }
        public Guid UserProfileId { get; set; }
        public InteractionType Type { get; set; }
    }
}
