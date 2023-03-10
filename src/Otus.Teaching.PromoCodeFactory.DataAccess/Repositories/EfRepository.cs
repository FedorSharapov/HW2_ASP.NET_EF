using Microsoft.EntityFrameworkCore;
using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DbContext Context;
        protected DbSet<T> EntitySet;

        public EfRepository(DbContext context)
        {
            Context = context;
            EntitySet = Context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await EntitySet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await EntitySet.FindAsync(id);
        }
    }
}
