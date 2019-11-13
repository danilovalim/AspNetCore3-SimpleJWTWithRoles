using JwtSimpleApp.Models;
using JwtSimpleApp.Repositories;
using JwtSimpleApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtSimpleApp.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        [Route("status")]
        [AllowAnonymous]
        public string Get()
        {
            return "API working...";
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult Post([FromBody]User user)
        {
            var _user = UserRepository.GetUser(user.Name, user.Password);

            if (_user == null)
            {
                return NotFound();
            }

            var token = TokenService.GenerateToken(_user);

            return Ok(token);
        }
    }
}