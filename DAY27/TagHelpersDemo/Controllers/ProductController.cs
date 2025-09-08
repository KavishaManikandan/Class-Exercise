using Microsoft.AspNetCore.Mvc;
using TagHelpersDemo.Models;

namespace TagHelpersDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product{Id=1, Name="Laptop", Price=800},
                new Product{Id=2, Name="Phone", Price=500},
                new Product{Id=3, Name="Tablet", Price=300}
            };

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            // Normally save to database
            return RedirectToAction("Index");
        }
    }
}
