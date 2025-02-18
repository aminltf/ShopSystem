#nullable disable

using ShopSystem.Domain.Common;
using ShopSystem.Domain.Enums;
using ShopSystem.Domain.ValueObjects;

namespace ShopSystem.Domain.Entities;

public class Product : BaseEntity<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Money Price { get; set; }
    public ProductStatus Status { get; set; }
    public int Stock { get; set; }

    private Product() { } // Required for EF Core

    public Product(string name, string description, Money price, int stock)
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        Status = ProductStatus.Active;
    }

    public void UpdateStock(int quantity)
    {
        Stock = Math.Max(0, Stock + quantity);
    }

    public void ChangeStatus(ProductStatus status)
    {
        Status = status;
    }
}
