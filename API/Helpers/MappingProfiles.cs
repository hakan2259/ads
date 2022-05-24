using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Advert,AdvertToReturnDto>()
            .ForMember(d=> d.PictureUrl, o=> o.MapFrom<AdvertUrlResolver>());
            
        }
    }
}