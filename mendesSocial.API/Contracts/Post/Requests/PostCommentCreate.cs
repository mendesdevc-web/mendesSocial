using System.ComponentModel.DataAnnotations;

namespace mendesSocial.Api.Contracts.Post.Requests
{
    public class PostCommentCreate
    {
        [Required]
        public string Text { get; set; }

    }
}
