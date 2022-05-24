using API.Dtos;
using AutoMapper;
using Core.Entities;
using Microsoft.Extensions.Configuration;

namespace API.Helpers
{
    public class AdvertUrlResolver : IValueResolver<Advert, AdvertToReturnDto, string>
    {
        private readonly IConfiguration _config;
        public AdvertUrlResolver(IConfiguration config)
        {
            _config = config;
        }
        public string Resolve(Advert source, AdvertToReturnDto destination, string destMember, ResolutionContext context)
        {
           if(!string.IsNullOrEmpty(source.PictureUrl)){
               return _config["ApiUrl"] + source.PictureUrl;
           }
           return null;
        }
    }
}