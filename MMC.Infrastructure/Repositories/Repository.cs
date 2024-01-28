using Microsoft.EntityFrameworkCore;
using MMC.Application.IRepositories;
using MMC.Infrastructure.Data;
using System.Linq.Expressions;

namespace MMC.Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly IBaseDbContext _db;
    private readonly DbSet<T> _set;

    public Repository(IBaseDbContext db)
    {
        _db = db;
        _set = _db.Set<T>();
    }



    public async Task<T?> GetAsync<TKey>(TKey id, params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = _set;

        foreach (var item in includes)
            query = query.Include(item);

        return await query.FirstOrDefaultAsync(e => EF.Property<TKey>(e, "Id").Equals(id));
    }
    public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = _set;

        foreach (var item in includes)
            query = query.Include(item);

        return await query.ToListAsync();
    }
    public async Task<bool> PostAsync(T entity)
    {
        await _set.AddAsync(entity);
        return true;
    }
    public async Task<T?> PutAsync<TKey>(TKey id, T entity)
    {
        var data = await GetAsync(id);
        if (data is null) return default;

        _set.Entry(data).CurrentValues.SetValues(entity);
        return data;
    }
    public async Task<bool> RemoveAsync<TKey>(TKey id)
    {
        var data = await GetAsync(id);
        if (data is not null)
        {
            _set.Remove(data);
            return true;
        }
        return false;
    }
}