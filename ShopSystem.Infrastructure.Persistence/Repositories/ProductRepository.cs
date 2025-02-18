#nullable disable

using Microsoft.EntityFrameworkCore;
using ShopSystem.Application.Interfaces;
using ShopSystem.Domain.Entities;
using ShopSystem.Domain.Enums;
using ShopSystem.Infrastructure.Persistence.Contexts;

namespace ShopSystem.Infrastructure.Persistence.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context) { }

    public async Task<IReadOnlyList<Product>> GetActiveProductsAsync()
    {
        return await _context.Products.Where(p => p.Status == ProductStatus.Active).ToListAsync();
    }
}
