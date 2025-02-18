#nullable disable

using ShopSystem.Domain.Common;
using ShopSystem.Domain.Entities;

namespace ShopSystem.Application.Interfaces;

public interface IOrderRepository : IGenericRepository<Order>
{
}
