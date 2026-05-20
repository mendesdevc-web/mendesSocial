using System.ComponentModel.DataAnnotations;

namespace mendesSocial.Api.Contracts.Post.Requests
{
    public class PostCommentUpdate
    {
        [Required]
        public string Text { get; set; }
    }
}
