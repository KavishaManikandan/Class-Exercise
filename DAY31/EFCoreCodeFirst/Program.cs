using System;
using System.Linq;
using EFCoreCodeFirst.Data;
using EFCoreCodeFirst.Models;

namespace EFCoreCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            // CREATE
            context.Products.Add(new Product { Name = "Laptop", Price = 800 });
            context.Products.Add(new Product { Name = "Phone", Price = 500 });
            context.SaveChanges();

            // READ
            var products = context.Products.ToList();
            Console.WriteLine("Products List:");
            products.ForEach(p => Console.WriteLine($"{p.Id} - {p.Name} - {p.Price}"));

            // UPDATE
            var productToUpdate = context.Products.First();
            productToUpdate.Price = 900;
            context.SaveChanges();
            Console.WriteLine($"Updated Product: {productToUpdate.Name} - {productToUpdate.Price}");

            // DELETE
            var productToDelete = context.Products.Last();
            context.Products.Remove(productToDelete);
            context.SaveChanges();
            Console.WriteLine($"Deleted Product: {productToDelete.Name}");
        }
    }
}
