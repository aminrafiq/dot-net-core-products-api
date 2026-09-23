using Models.ServiceModels;
using ProductApi.Infrastructure.Repositories;

namespace ProductApi.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<ProductModel>> GetProductsAsync()
    {
        var products = await _productRepository.GetProductsAsync();

        return products.Select(product => new ProductModel
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price
        }).ToList();
    }
}
