#nullable disable

using ShopSystem.Application.Interfaces;

namespace ShopSystem.Modules.Products.Services;

public class ProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<bool> IsProductInStock(Guid productId)
    {
        var product = await _productRepository.GeByIdAsync(productId);
        return product != null && product.Stock > 0;
    }
}
