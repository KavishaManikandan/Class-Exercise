using System;
using System.Linq;
using EFCoreCRUDDemo.Data;
using EFCoreCRUDDemo.Models;

namespace EFCoreCRUDDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            // CREATE Categories
            var electronics = new Category { Name = "Electronics" };
            var groceries = new Category { Name = "Groceries" };
            context.Categories.AddRange(electronics, groceries);
            context.SaveChanges();

            // CREATE Products
            var laptop = new Product { Name = "Laptop", Price = 1000, Category = electronics };
            var phone = new Product { Name = "Phone", Price = 500, Category = electronics };
            var apple = new Product { Name = "Apple", Price = 2, Category = groceries };
            context.Products.AddRange(laptop, phone, apple);
            context.SaveChanges();

            // READ Products with Categories (Navigation Property)
            var products = context.Products
                .Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name })
                .ToList();

            Console.WriteLine("Products List:");
            foreach (var p in products)
                Console.WriteLine($"{p.Name} - {p.Price} - Category: {p.CategoryName}");

            // UPDATE Product
            var productToUpdate = context.Products.First(p => p.Name == "Laptop");
            productToUpdate.Price = 1200;
            context.SaveChanges();
            Console.WriteLine($"Updated Product: {productToUpdate.Name} - {productToUpdate.Price}");

            // DELETE Product
            var productToDelete = context.Products.First(p => p.Name == "Apple");
            context.Products.Remove(productToDelete);
            context.SaveChanges();
            Console.WriteLine($"Deleted Product: {productToDelete.Name}");

            // Optimizing Query: LINQ to get Electronics products only
            var electronicsProducts = context.Products
                .Where(p => p.Category.Name == "Electronics")
                .Select(p => new { p.Name, p.Price })
                .ToList();

            Console.WriteLine("\nElectronics Products:");
            electronicsProducts.ForEach(p => Console.WriteLine($"{p.Name} - {p.Price}"));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
