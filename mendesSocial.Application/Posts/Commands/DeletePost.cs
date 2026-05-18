using MediatR;
using mendes.Application.Models;
using mendes.Domain.Aggregates.PostAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mendes.Application.Posts.Commands
{
    public class DeletePost : IRequest<OperationResult<Post>>
    {
        public Guid PostId { get; set; }
        public Guid UserProfileId { get; set; }
    }
}
