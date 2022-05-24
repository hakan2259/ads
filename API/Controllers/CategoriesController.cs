using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly IGenericRepository<Category> _categoryRepo;
        public CategoriesController(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Category>>> GetCategories(){
            return Ok(await _categoryRepo.ListAllAsync());
        }
    }
}