#nullable disable

using ShopSystem.Application.Interfaces;
using ShopSystem.Domain.Entities;

namespace ShopSystem.Infrastructure.Persistence.Repositories;

public class OrderRepository : IOrderRepository
{
    public Task AddAsync(Order entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Order>> GeAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Order> GeByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Order entity)
    {
        throw new NotImplementedException();
    }
}
