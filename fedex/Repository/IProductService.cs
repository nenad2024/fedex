using fedex.Api.Model.DTOs;

namespace fedex.Api.Repository
{
    public interface IProductService
    {
        public IEnumerable<ProductDTO> GetProducts();

        public ProductDTO CreateProduct(ProductDTO product);
        public void UpdateProduct(ProductDTO product);
        public void DeleteProduct(int id);
    }
}
