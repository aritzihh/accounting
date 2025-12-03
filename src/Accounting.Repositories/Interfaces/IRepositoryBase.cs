using System.Linq.Expressions;

namespace Accounting.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity>
    {
        Task<int> AddAsync(TEntity entity);
        Task DeleteAsync(int id);
        Task<ICollection<TEntity>> GetAsync();
        Task<ICollection<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity?> GetAsync(int id);
        Task<ICollection<TEntity>> GetAsync<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy);
        Task UpdateAsync();
    }
}