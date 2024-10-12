using fedex.Api.Model.DTOs;
using Microsoft.EntityFrameworkCore;

namespace fedex.Api.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<ProductDTO> Products { get; set; } = default!;
    }
}
