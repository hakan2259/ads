using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdvertsController : ControllerBase
    {
        private readonly IAdvertRepository _repository;
        public AdvertsController(IAdvertRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Advert>>> GetAdverts()
        {
            var adverts = await _repository.GetAdvertsAsync();
            return Ok(adverts);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Advert>> GetProduct(int id)
        {
            return await _repository.GetAdvertByIdAsync(id);
        }
    }
}