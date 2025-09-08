using Microsoft.AspNetCore.Mvc;
using AdvancedRoutingDemo.Models;
using System.Collections.Generic;

namespace AdvancedRoutingDemo.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product{Id=1, Name="Laptop"},
            new Product{Id=2, Name="Phone"},
            new Product{Id=3, Name="Tablet"}
        };

        // Default route
        public IActionResult Index()
        {
            return View(products);
        }

        // Dynamic route based on id
        [Route("Product/Details/{id:int:min(1)}")]
        public IActionResult Details(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product == null)
                return NotFound("Product not found");
            return View(product);
        }
    }
}
