using System.ComponentModel.DataAnnotations;

namespace mendesSocial.Api.Contracts.Post.Requests
{
    public class PostUpdate
    {
        [Required]
        public string Text { get; set; }
    }
}
