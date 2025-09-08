using Microsoft.AspNetCore.Mvc;
using FullFeatureApp.Models;

namespace FullFeatureApp.Controllers
{
    public class HomeController : Controller
    {
        [TypeFilter(typeof(Filters.LogActionFilter))]
        public IActionResult Index()
        {
            HttpContext.Session.SetString("SessionStart", DateTime.Now.ToString());
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Store username in session
                HttpContext.Session.SetString("Username", user.UserName);
                return RedirectToAction("Welcome");
            }
            return View(user);
        }

        public IActionResult Welcome()
        {
            var username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
                return RedirectToAction("Register");

            ViewBag.Username = username;
            return View();
        }
    }
}
