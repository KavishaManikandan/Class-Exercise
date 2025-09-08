using Microsoft.EntityFrameworkCore;
using EFCoreCodeFirst.Models;

namespace EFCoreCodeFirst.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=YOUR_SERVER_NAME;Database=EFCoreCodeFirstDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(10,2)");
        }
    }
}
