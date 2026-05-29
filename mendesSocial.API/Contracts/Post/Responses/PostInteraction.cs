using mendes.Domain.Aggregates.PostAggregate;
using mendes.Domain.Aggregates.UserProfileAggregate;

namespace mendesSocial.Api.Contracts.Post.Responses
{
    public class PostInteraction
    {
        public Guid InteractionId { get; set; }
        public string Type { get; set; }
        public InteractionUser Author { get; set; }
    }
}
