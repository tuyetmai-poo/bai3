using System.ComponentModel.DataAnnotations;

namespace bai2.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength (100,MinimumLength =2)]
        public string? Name { get; set; }
        [Range(1, 1000, ErrorMessage = "Gia tri vuot ")]
        public decimal Price { get; set; }

        public string? Description { get; set; }
    }
}
