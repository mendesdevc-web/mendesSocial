using mendes.Domain.Validators.PostValidators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mendes.Domain.Aggregates.PostAggregate
{
    public class Post
    {
        private readonly List<PostComment> _comments = new List<PostComment>();
        private readonly List<PostInteraction> _interactions = new List<PostInteraction>();

        private Post()
        {
        }

        public Guid PostId { get; private set; }
        public Guid UserProfileId { get; private set; }
        public UserProfileAggregate.UserProfile UserProfile { get; private set; }
        public string TextContent { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastModified { get; private set; }
        public IEnumerable<PostComment> Comments { get { return _comments; } }
        public IEnumerable<PostInteraction> Interactions { get { return _interactions; } }

        //Factory methods
        public static Post CreatePost(Guid userProfileId, string textContent)
        {
           var validator = new PostValidator();
           var objectToValidate = new Post
            {
                UserProfileId = userProfileId,
                TextContent = textContent,
                CreatedDate = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };

            var validationResult = validator.Validate(objectToValidate);
            if (validationResult.IsValid) return objectToValidate;

        }
        public void UptadePostText(string newText)
        {
            TextContent = newText;
            LastModified = DateTime.UtcNow;
        }
        
        public void AddPostComment(PostComment newComment)
        {
            _comments.Add(newComment);
        }

        public void RemoveComment(PostComment toRemove)
        {
            _comments.Remove(toRemove);
        }

        public void addInteraction(PostInteraction newInteraction)
        {
            _interactions.Add(newInteraction);
        }   

        public void RemoveInteraction(PostInteraction toRemove)
        {
                _interactions.Remove(toRemove);
        }
    }
}
