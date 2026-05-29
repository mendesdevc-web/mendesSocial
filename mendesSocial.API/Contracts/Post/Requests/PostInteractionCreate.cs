using mendes.Domain.Aggregates.PostAggregate;
using System.ComponentModel.DataAnnotations;

namespace mendesSocial.Api.Contracts.Post.Requests
{
    public class PostInteractionCreate
    {
        [Required]
        public InteractionType Type { get; set; }
    }
}
