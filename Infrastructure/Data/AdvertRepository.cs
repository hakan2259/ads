using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AdvertRepository : IAdvertRepository
    {
        private readonly AdsContext _context;
        public AdvertRepository(AdsContext context)
        {
            _context = context;
        }
        public async Task<Advert> GetAdvertByIdAsync(int id)
        {
            return await _context.Adverts.FindAsync(id);
        }
        public async Task<IReadOnlyList<Advert>> GetAdvertsAsync()
        {
            return await _context.Adverts
            .ToListAsync();
        }
    }
}