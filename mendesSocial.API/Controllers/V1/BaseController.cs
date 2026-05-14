using Azure;
using mendes.Application.Enums;
using mendes.Application.Models;
using mendesSocial.Api.Contracts.Common;
using Microsoft.AspNetCore.Mvc;

namespace mendesSocial.Api.Controllers.V1
{
    public class BaseController : ControllerBase
    {
       protected IActionResult HandleErrorResponse(List<Error> errors)
        {
            var apiError = new ErrorResponse();

            if (errors.Any(e => e.Code == ErrorCode.NotFound))
            {
                var error = errors.FirstOrDefault(e => e.Code == ErrorCode.NotFound);

                apiError.StatusCode = 404;
                apiError.StatusPhrase = "Not Found";
                apiError.Timestamp = DateTime.Now;
                apiError.Errors.Add(error.Message);

                return NotFound(apiError);
            }
            
            
            apiError.StatusCode = 404;
            apiError.StatusPhrase = "Internal server error";
            apiError.Timestamp = DateTime.Now;
            apiError.Errors.Add("Unknow error");

            return NotFound(apiError);

        }
    }
}
