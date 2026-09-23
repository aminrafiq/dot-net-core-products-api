using Microsoft.AspNetCore.Mvc;
using ProductApi.Services;

namespace ProductApi.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        
        var products = await _productService.GetProductsAsync();

        return Ok(products);
    }
}
