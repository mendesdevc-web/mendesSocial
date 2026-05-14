using Microsoft.AspNetCore.Mvc;

namespace mendesSocial.Api.Controllers.V1
{

    [ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class PostsController : BaseController
    {
        [HttpGet]
        [Route(ApiRoutes.Posts.GetById)]
        public IActionResult GetByID(int id)
        {
            return Ok();
        }
    }
}
