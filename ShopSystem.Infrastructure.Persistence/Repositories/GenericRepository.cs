#nullable disable

using Microsoft.EntityFrameworkCore;
using ShopSystem.Domain.Common;
using ShopSystem.Infrastructure.Persistence.Contexts;

namespace ShopSystem.Infrastructure.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity<Guid>
{
    protected readonly ApplicationDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GeByIdAsync(id);
        if (entity is not null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IList<T>> GeAllAsync() => await _dbSet.ToListAsync();

    public async Task<T> GeByIdAsync(Guid id) => await _dbSet.FindAsync(id);
}
