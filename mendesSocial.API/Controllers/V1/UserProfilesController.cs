using MediatR;
using mendes.Domain.Aggregates.UserProfileAggregate;
using mendesSocial.Api.Contracts.UserProfile.Requests;
using Microsoft.AspNetCore.Mvc;

namespace mendesSocial.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class UserProfilesController : Controller
    {
        private readonly IMediator _mediator;
        public UserProfilesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllProfiles()
        {
            return await Task.FromResult(Ok());
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserProfile([FromBody] UserProfileCreateUpdate profile)
        {
            return (IActionResult)Task.FromResult(Ok());
        }
    }
}
