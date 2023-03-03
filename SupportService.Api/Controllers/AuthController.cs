
using Microsoft.AspNetCore.Mvc;
using SupportService.Application.Services.AuthService;
using SupportService.Domain;

namespace SupportService.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

     /*   [HttpPost("login")]
        public IActionResult Login(User user)
        {
            var authResult = _authService.Login();
            return Ok();
        }*/

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            return Ok(_authService.Register(user));
        }
    }
}
