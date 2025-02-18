#nullable disable

using ShopSystem.Application.Interfaces;
using ShopSystem.Domain.Entities;

namespace ShopSystem.Infrastructure.Persistence.Repositories;

public class PaymentRepository : IPaymentRepository
{
    public Task AddAsync(Payment entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Payment>> GeAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Payment> GeByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Payment entity)
    {
        throw new NotImplementedException();
    }
}
