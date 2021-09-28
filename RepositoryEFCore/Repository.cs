using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryEFCore
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext Context;
        public Repository(ApplicationDbContext context) => Context = context;

        public IEnumerable<T> FindWithSpecificationPattern(ISpecification<T> specification = null)
        {
            return Context.Set<T>().AsQueryable();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Context.Set<T>().FindAsync(id);
        }
    }
}