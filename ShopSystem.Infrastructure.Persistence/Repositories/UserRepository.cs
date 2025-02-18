#nullable disable

using ShopSystem.Application.Interfaces;
using ShopSystem.Domain.Entities;

namespace ShopSystem.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    public Task AddAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<User>> GeAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> GeByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(User entity)
    {
        throw new NotImplementedException();
    }
}
