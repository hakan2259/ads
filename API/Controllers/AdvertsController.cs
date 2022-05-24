using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdvertsController : ControllerBase
    {
        private readonly IGenericRepository<Advert> _advertsRepo;
        private readonly IMapper _mapper;
        public AdvertsController(IGenericRepository<Advert> advertsRepo, 
        IMapper mapper
        )
        {
            _advertsRepo = advertsRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AdvertToReturnDto>>> GetAdverts()
        {
            var spec = new AdvertsWithCategoriesSpecification();
            var adverts = await _advertsRepo.ListAsync(spec);
            return Ok(_mapper.Map<IReadOnlyList<Advert>,IReadOnlyList<AdvertToReturnDto>>(adverts));

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AdvertToReturnDto>> GetAdvert(int id)
        {
            var spec = new AdvertsWithCategoriesSpecification(id);

            var advert = await _advertsRepo.GetEntityWithSpec(spec);
            return _mapper.Map<Advert,AdvertToReturnDto>(advert);

        }
    }
}