using mendes.Domain.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mendes.Domain.Aggregates.Friendships
{
    public class Friendship
    {
        internal Friendship() { }
        public Guid FriendshipId { get; internal set; }
        public Guid? FirstFriendUserProfileId { get; internal set; }
        public UserProfile? FirstFriend { get; internal set; }
        public Guid? SecondFriendUserProfileId { get; internal set; }
        public UserProfile? SecondFriend { get; internal set; }
        public DateTime DateEstablished { get; internal set; }
        public FriendshipStatus FriendshipStatus { get; internal set; }

        public void Unfriend()
        {
            FriendshipStatus = FriendshipStatus.Inactive;
        }
    }
}
