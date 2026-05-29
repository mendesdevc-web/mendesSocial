using System.ComponentModel.DataAnnotations;

namespace mendesSocial.Api.Contracts.Friendships_Requests
{
    public class FriendRequestCreate
    {
        [Required]
        public Guid RequesterId { get; set; }

        [Required]
        public Guid ReceiverId { get; set; }
    }
}
