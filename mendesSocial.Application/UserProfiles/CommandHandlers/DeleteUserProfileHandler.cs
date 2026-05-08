using MediatR;
using mendes.Application.UserProfiles.CommandHandlers;
using mendes.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mendes.Application.UserProfiles.Commands
{
    internal class DeleteUserProfileHandler : IRequestHandler<DeleteUserProfile>
    {
        private readonly DataContext _ctx;
        public DeleteUserProfileHandler(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Unit> Handle(DeleteUserProfile request, CancellationToken cancellationToken)
        {
            var userProfile = _ctx.UserProfiles
                .FirstOrDefault(up => up.UserProfileId == request.UserProfileId);

            _ctx.UserProfiles.Remove(userProfile);
            await _ctx.SaveChangesAsync();

            return new Unit();
        }
    }
}
