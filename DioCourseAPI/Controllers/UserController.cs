using System.Linq;
using DioCourseAPI.Filters;
using DioCourseAPI.Models;
using DioCourseAPI.Models.Users;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DioCourseAPI.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// teste
        /// </summary>
        /// <param name="loginViewModelInput"></param>
        /// <returns></returns>
        [SwaggerResponse(statusCode: 200, description: "Authentication Successful", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Mandatory Field", Type = typeof(ValidFieldViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Internal Error", Type = typeof(GenericErrorViewModel))]
        [HttpPost]
        [Route("login")]
        [ValidationModelStateCustomized]
        public IActionResult Login(LoginViewModelInput loginViewModelInput)
        {
            // if (!ModelState.IsValid)
            // {
            //     return BadRequest(new ValidFieldViewModelOutput(ModelState.SelectMany(pair => pair.Value.Errors)
            //         .Select(s => s.ErrorMessage)));
            // }
            return Ok(loginViewModelInput);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entryViewModelInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("register")]
        [ValidationModelStateCustomized]
        public IActionResult Register(EntryViewModelInput entryViewModelInput)
        {
            return Created("", entryViewModelInput);
        }
    }
}