using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AdvertRepository : IGenericRepository<Advert>, IAdvertRepository
    {
        public Task<Advert> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Advert> GetEntityWithSpec(ISpecification<Advert> spec)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<Advert>> ListAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<Advert>> ListAsync(ISpecification<Advert> spec)
        {
            throw new System.NotImplementedException();
        }
    }
}