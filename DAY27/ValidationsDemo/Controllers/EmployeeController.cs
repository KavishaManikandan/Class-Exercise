using Microsoft.AspNetCore.Mvc;
using ValidationsDemo.Models;

namespace ValidationsDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                // Normally save to DB
                return RedirectToAction("Success");
            }
            return View(emp);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
