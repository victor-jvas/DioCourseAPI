using Microsoft.AspNetCore.Mvc;

namespace DioCourseAPI.Controllers
{
    public class User : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}