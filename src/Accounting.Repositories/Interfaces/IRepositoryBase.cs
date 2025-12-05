using System.Linq.Expressions;

namespace Accounting.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity>
    {
        Task<ICollection<TEntity>> GetAsync(); // GET ALL
        Task<ICollection<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate); // GET con filtro
        Task<ICollection<TEntity>> GetAsync<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy); // GET filtro y ordenado
        Task<TEntity?> GetAsync(int id); // GET por id
        Task<int> AddAsync(TEntity entity); // POST
        Task UpdateAsync(); // PUT
        Task DeleteAsync(int id); // UPDATE (IsActive = false)
    }
}