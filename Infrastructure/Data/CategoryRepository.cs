using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class CategoryRepository : IGenericRepository<Category>,ICategoryRepository
    {
        private readonly AdsContext _context;
        public CategoryRepository(AdsContext context)
        {
            _context = context;
        }

        public Task<Category> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Category> GetEntityWithSpec(ISpecification<Category> spec)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IReadOnlyList<Category>> ListAllAsync()
        {
             return await _context.Categories.ToListAsync();
        }

        public Task<IReadOnlyList<Category>> ListAsync(ISpecification<Category> spec)
        {
            throw new System.NotImplementedException();
        }
    }
}