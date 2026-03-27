using System.ComponentModel.DataAnnotations;

namespace WebBanHang_Lab03.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
        // Uncomment if you have Category model
        // public Category Category { get; set; }
    }
}
