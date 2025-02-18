#nullable disable

using Microsoft.EntityFrameworkCore;
using ShopSystem.Domain.Entities;

namespace ShopSystem.Infrastructure.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
}
