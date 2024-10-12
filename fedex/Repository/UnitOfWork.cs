using fedex.Api.Data;

namespace fedex.Api.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ProductContext _productContext;
        public IProductService _productService;


        public UnitOfWork(ProductContext productContext) { _productContext = productContext; }

        public IProductService ProductService
        {
            get
            {
                return _productService ??= new ProductService(_productContext);
            }
        }

        public void Dispose()
        {
            _productContext?.Dispose();
        }
    }
}
