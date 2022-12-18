using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REWE.JobService.Api.Contracts;
using REWE.JobService.Application.Identity;
using REWE.JobService.Application.Users;

namespace REWE.JobService.Api.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IIdentityService _identityService;

        public AuthController(IIdentityService identityService)
        {
            _identityService = identityService;

        }
        [HttpPost("token")]
        [AllowAnonymous]
        public async Task<ActionResult<LoginResponse>> Token([FromBody]LoginRequest request)
        {
            var result=await _identityService.GetToken(request.UserName, request.Password);    
            return Ok(new LoginResponse(result.Token, result.Expire));
        }
    }
}
