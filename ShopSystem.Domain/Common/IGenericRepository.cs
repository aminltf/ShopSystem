#nullable disable

namespace ShopSystem.Domain.Common;

public interface IGenericRepository<T> where T : BaseEntity<Guid>
{
    Task<IList<T>> GeAllAsync();
    Task<T> GeByIdAsync(Guid id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(Guid id);
}
