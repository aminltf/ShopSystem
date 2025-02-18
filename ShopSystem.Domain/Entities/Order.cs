#nullable disable

using ShopSystem.Domain.Common;
using ShopSystem.Domain.Enums;

namespace ShopSystem.Domain.Entities;

public class Order : BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public List<OrderItem> Items { get; set; } = new();
    public decimal TotalPrice => Items.Sum(i => i.Quantity * i.UnitPrice);
    public OrderStatus Status { get; set; } = OrderStatus.Pending;

    private Order() { } // Required for EF Core

    public Order(Guid userId, List<OrderItem> items, OrderStatus status)
    {
        UserId = userId;
        Items = items;
        Status = status;
    }

    public void Confirm() => Status = OrderStatus.Confirmed;
}
