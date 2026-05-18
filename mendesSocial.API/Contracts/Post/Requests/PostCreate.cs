using System.ComponentModel.DataAnnotations;

namespace mendesSocial.Api.Contracts.Post.Requests
{
    public class PostCreate
    {
        [Required]
        public string TextContent { get; set; }
        public Guid UserProfileId { get; internal set; }
    }
}
