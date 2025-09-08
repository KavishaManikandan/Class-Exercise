using Microsoft.EntityFrameworkCore;
using EFCoreCRUDDemo.Models;

namespace EFCoreCRUDDemo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=YOUR_SERVER_NAME;Database=EFCoreCRUDDemoDB;Trusted_Connection=True;");
        }
    }
}
