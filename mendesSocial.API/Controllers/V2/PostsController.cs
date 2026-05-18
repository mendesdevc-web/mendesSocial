using mendes.Domain.Aggregates.PostAggregate;
using Microsoft.AspNetCore.Mvc;

namespace mendes.Api.Controllers.V2
{

    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetByID(int id)
        {
            return Ok();
        }
    }
}
