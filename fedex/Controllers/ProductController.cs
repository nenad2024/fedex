using fedex.Api.Model.DTOs;
using fedex.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fedex.Api.Controllers
{
    
    [ApiController]
    public class ProductController : ControllerBase
    {
        IUnitOfWork _productService;
        public ProductController(IUnitOfWork productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("api/[controller]/GetProducts")]
        public IEnumerable<ProductDTO> GetProducts()
        {
            return _productService.ProductService.GetProducts();
        }

        [HttpPost]
        [Route("api/[controller]/CreateProduct")]
        public ProductDTO CreateProduct(ProductDTO product)
        {
            return _productService.ProductService.CreateProduct(product);
        }

        [HttpDelete]
        [Route("api/[controller]/DeleteProduct/{id}")]
        public void DeleteProduct(int id)
        {
            _productService.ProductService.DeleteProduct(id);
        }

        [HttpPut]
        [Route("api/[controller]/UpdateProduct/{id}")]
        public void UpdateProduct(ProductDTO updateProduct)
        {
            _productService.ProductService.UpdateProduct(updateProduct);
        }
    }
}

