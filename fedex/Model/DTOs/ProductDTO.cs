using System.ComponentModel.DataAnnotations;

namespace fedex.Api.Model.DTOs
{
    public class ProductDTO
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double? Price { get; set; }
        public string? Description { get; set; }
        public int? StockQuantity { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
