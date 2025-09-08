using System.ComponentModel.DataAnnotations;

namespace EFCoreCodeFirst.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
