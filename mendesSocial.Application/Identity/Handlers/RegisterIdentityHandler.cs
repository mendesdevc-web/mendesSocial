using MediatR;
using mendes.Application.Enums;
using mendes.Application.Identity.Commands;
using mendes.Application.Models;
using mendes.Application.Options;
using mendes.Dal;
using mendes.Domain.Aggregates.UserProfileAggregate;
using mendes.Domain.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;


namespace mendes.Application.Identity.Handlers
{
    public class RegisterIdentityHandler : IRequestHandler<RegisterIdentity, OperationResult<string>>
    {
        private readonly DataContext _ctx;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtSettings _jwtSettings;

        public RegisterIdentityHandler(DataContext ctx, UserManager<IdentityUser> userManager, 
            IOptions<JwtSettings> jwtSettings)
        {
            _ctx = ctx;
            _userManager = userManager;
            _jwtSettings = jwtSettings.Value;
        }

        public async Task<OperationResult<string>> Handle(RegisterIdentity request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<string>();

            try
            {
                var existingUser = await _userManager.FindByNameAsync(request.Username);

                if (existingUser != null)
                {
                    result.IsError = true;
                    var error = new Error
                    {
                        Code = ErrorCode.IdentityUserAlreadyExists,
                        Message = "Username already exists."
                    };
                    result.Errors.Add(error);
                    return result;

                }


                var identity = new IdentityUser
                {
                    Email = request.Username,
                    UserName = request.Username
                };

                //creating transaction
                using var transaction = _ctx.Database.BeginTransaction();

                var CreateIdentity = await _userManager.CreateAsync(identity, request.Password);
                if (!CreateIdentity.Succeeded)
                {

                    result.IsError = true;

                    foreach (var identityError in CreateIdentity.Errors)
                    {
                        var error = new Error
                        {
                            Code = ErrorCode.IdentityCreationFailed,
                            Message = identityError.Description
                        };
                        result.Errors.Add(error);
                    }
                    return result;
                }

                var profileInfo = BasicInfo.CreateBasicInfo(request.FirstName, request.LastName, request.Username,
                request.Phone, request.DateOfBirth, request.CurrentCity);

                var profile = UserProfile.CreateUserProfile(identity.Id, profileInfo);

                _ctx.UserProfiles.Add(profile);
                await _ctx.SaveChangesAsync();
                await transaction.CommitAsync();


                var tokenHandler = new JwtSecurityTokenHandler();



            }
            catch (UserProfileNotValidException ex)
            {
                result.IsError = true;
                ex.ValidationErrors.ForEach(e =>
                {
                    var error = new Error
                    {
                        Code = ErrorCode.ValidationError,
                        Message = $"{ex.Message}"
                    };
                    result.Errors.Add(error);

                });

                return result;
            }
        }
    }
}
