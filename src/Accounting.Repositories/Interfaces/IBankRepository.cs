using Accounting.Entities;

namespace Accounting.Repositories.Interfaces
{
    public interface IBankRepository
    {
        Task<ICollection<Bank>> GetAsync();
        Task<Bank?> GetByIdAsync(int id);
        Task<int> AddAsync(Bank entity);
        Task UpdateAsync(Bank entity);
        Task DeleteAsync(int id);
    }
}