using ProductApi.Infrastructure.Entities;

namespace ProductApi.Infrastructure.Repositories;

public interface IProductRepository
{
    Task<List<Product>> GetProductsAsync();
}
