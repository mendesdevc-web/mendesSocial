using mendes.Domain.Aggregates.Friendships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mendes.Application.UserProfiles.Models
{
    public class FriendRequestDto
    {
        public Guid FriendRequestId { get; set; }
        public string? RequesterFullname { get; set; }
        public string? City { get; set; }

        public static FriendRequestDto FromFriendRequest(FriendRequest request)
        {
            return new FriendRequestDto
            {
                FriendRequestId = request.FriendRequestId,
                RequesterFullname = $"{request.Requester.BasicInfo.FirstName} {request.Requester.BasicInfo.LastName}",
                City = request.Requester.BasicInfo.CurrentCity
            };
        }
    }
}
