using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace AuthDemoApp.Controllers
{
    public class HomeController : Controller
    {
        [Authorize] // Any logged-in user
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")] // Only Admin
        public IActionResult AdminOnly()
        {
            return Content("Welcome Admin!");
        }
    }
}
