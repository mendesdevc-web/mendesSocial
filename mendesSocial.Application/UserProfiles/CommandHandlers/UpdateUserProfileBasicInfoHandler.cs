using MediatR;
using mendes.Application.UserProfiles.Commands;
using mendes.Dal;
using mendes.Domain.Aggregates.UserProfileAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mendes.Application.UserProfiles.CommandHandlers
{
    internal class UpdateUserProfileBasicInfoHandler : IRequestHandler<UpdateUserProfileBasicInfo>
    {
        private readonly DataContext _ctx;

        public UpdateUserProfileBasicInfoHandler(DataContext context)
        {
            _ctx = context;
        }

        public async Task<Unit> Handle(UpdateUserProfileBasicInfo request, 
            CancellationToken cancellationToken)
        {
           var userProfile = await _ctx.UserProfiles
                .FirstOrDefaultAsync(up => up.UserProfileId == request.UserProfileId);

           var basicInfo = BasicInfo.CreateBasicInfo(request.FirstName, request.LastName,
                request.EmailAddress, request.Phone, request.DateOfBirth, request.CurrentCity);

            userProfile.UpdateBasicInfo(basicInfo);

            _ctx.UserProfiles.Update(userProfile);
            await _ctx.SaveChangesAsync();

            return new Unit();

        }
    }
}
