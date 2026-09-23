using Models.ServiceModels;

namespace ProductApi.Services;

public interface IProductService
{
    Task<List<ProductModel>> GetProductsAsync();
}
