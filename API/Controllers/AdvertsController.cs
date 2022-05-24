using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Errors;
using API.Helpers;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class AdvertsController : BaseApiController
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
        public async Task<ActionResult<Pagination<AdvertToReturnDto>>> GetAdverts(
            [FromQuery] AdvertSpecParams advertParams)
        {
            var spec = new AdvertsWithCategoriesSpecification(advertParams);
            var countSpec = new AdvertWithFiltersForCountSpecification(advertParams);
            var totalItems = await _advertsRepo.CountAsync(countSpec);
            var adverts = await _advertsRepo.ListAsync(spec);
            var data = _mapper.Map<IReadOnlyList<Advert>, IReadOnlyList<AdvertToReturnDto>>(adverts);
            return Ok(new Pagination<AdvertToReturnDto>(advertParams.PageIndex, advertParams.PageSize, totalItems, data));


        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AdvertToReturnDto>> GetAdvert(int id)
        {
            var spec = new AdvertsWithCategoriesSpecification(id);

            var advert = await _advertsRepo.GetEntityWithSpec(spec);
            if (advert == null) return NotFound(new ApiResponse(404));
            return _mapper.Map<Advert, AdvertToReturnDto>(advert);

        }
    }
}