using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.Entities;
using Accounting.Persistence;
using Accounting.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Accounting.Repositories.Implementations
{
    public class BankRepository : RepositoryBase<Bank>, IBankRepository
    {

        private readonly ApplicationDbContext context;

        public BankRepository(ApplicationDbContext context) : base(context)
        {

            this.context = context;

        }

        public async Task<ICollection<Bank>> GetAsync()
        {
            var items = await base.GetAsync(b => b.IsActive == 1);
            return items;
        }

        public async Task<Bank?> GetByIdAsync(int id)
        {
            return await context.Set<Bank>()
                .AsNoTracking()
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public override async Task<int> AddAsync(Bank entity)
        {
            return await base.AddAsync(entity);
        }

        public async Task UpdateAsync(Bank entity)
        {
            context.Set<Bank>().Update(entity);
            await base.UpdateAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await base.DeleteAsync(id);
        }


    }
}
