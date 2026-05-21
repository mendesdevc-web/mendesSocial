using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mendes.Domain.Exceptions
{
    public class FriendRequestValidationException : DomainModelInvalidException
    {
        internal FriendRequestValidationException() { }
        internal FriendRequestValidationException(string message) : base(message) { }
        internal FriendRequestValidationException(string message, Exception inner) : base(message, inner) { }
    }
}
