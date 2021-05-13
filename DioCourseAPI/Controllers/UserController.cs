using DioCourseAPI.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace DioCourseAPI.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginViewModelInput loginViewModelInput)
        {
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(EntryViewModelInput entryViewModelInput)
        {
            return Created("", entryViewModelInput);
        }
    }
}