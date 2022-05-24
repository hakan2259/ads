using Core.Entities;

namespace Core.Specifications
{
    public class AdvertWithFiltersForCountSpecification : BaseSpecification<Advert>
    {
        public AdvertWithFiltersForCountSpecification(AdvertSpecParams advertParams)
         : base(x =>
         (string.IsNullOrEmpty(advertParams.Search) || x.Title.ToLower().Contains
            (advertParams.Search)) &&
            (!advertParams.categoryId.HasValue || x.CategoryId == advertParams.categoryId)
        )
        {

        }
    }
}