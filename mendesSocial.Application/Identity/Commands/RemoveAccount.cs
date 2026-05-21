using MediatR;
using mendes.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mendes.Application.Identity.Commands
{
    public class RemoveAccount : IRequest<OperationResult<bool>>
    {
        public Guid IdentityUserId { get; set; }
        public Guid RequestorGuid { get; set; }
    }
}
