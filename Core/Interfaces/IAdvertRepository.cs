using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IAdvertRepository
    {
         Task<Advert> GetAdvertByIdAsync(int id);
         Task<IReadOnlyList<Advert>> GetAdvertsAsync();
         

    }
}