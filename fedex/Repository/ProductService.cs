using fedex.Api.Data;
using fedex.Api.Model.DTOs;

namespace fedex.Api.Repository
{
    public class ProductService : IProductService
    {
        ProductContext _context;
        public ProductService(ProductContext context)
        {
            _context = context;
        }
        public ProductDTO CreateProduct(ProductDTO product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void DeleteProduct(int id)
        {
            var selectedProduct = _context.Products.FirstOrDefault(p=>p.ProductId == id);
            _context.Remove(selectedProduct);
            _context.SaveChanges();
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void UpdateProduct(ProductDTO product)
        {
            var existingproduct = _context.Products.Where(p=>p.ProductId == product.ProductId).FirstOrDefault();

            existingproduct.Price = product.Price;
            existingproduct.ProductName = product.ProductName;
            existingproduct.Description = product.Description;
            existingproduct.StockQuantity = product.StockQuantity;
            existingproduct.CreatedAt = product.CreatedAt;
            
            _context.SaveChanges();
        }
    }
}
