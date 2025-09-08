using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FiltersDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [TypeFilter(typeof(LogActionFilter))]
        public IActionResult About()
        {
            // Simulate error
            int x = 0;
            int y = 5 / x; // will throw exception
            return View();
        }
    }
}
