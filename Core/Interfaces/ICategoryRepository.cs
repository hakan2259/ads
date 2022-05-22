using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface ICategoryRepository
    {
         Task<IReadOnlyList<Category>> GetCategoriesAsync();
    }
}