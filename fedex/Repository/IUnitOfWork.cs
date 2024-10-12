

namespace fedex.Api.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IProductService ProductService { get; }
    }
}
