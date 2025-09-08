using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreCRUDDemo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Navigation property
        public List<Product> Products { get; set; }
    }
}
