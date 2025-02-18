#nullable disable

using ShopSystem.Domain.Common;
using ShopSystem.Domain.Entities;

namespace ShopSystem.Application.Interfaces;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<IReadOnlyList<Product>> GetActiveProductsAsync();
}
