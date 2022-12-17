using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace REWE.JobService.Api.Controllers.V1
{
    [Route("api/apply")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet("health-check")]
        public IActionResult Check()
        {
            return Ok();
        }
    }
}
