using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class AdvertsWithCategoriesSpecification : BaseSpecification<Advert>
    {
        public AdvertsWithCategoriesSpecification(AdvertSpecParams advertParams)
        : base(x =>
            (string.IsNullOrEmpty(advertParams.Search) || x.Title.ToLower().Contains
            (advertParams.Search)) &&
            (!advertParams.categoryId.HasValue || x.CategoryId == advertParams.categoryId)
        )
        {
            AddInclude(x => x.Category);
            AddOrderBy(x => x.Title);
            ApplyPaging(advertParams.PageSize * (advertParams.PageIndex - 1), advertParams.PageSize);

            if (!string.IsNullOrEmpty(advertParams.Sort))
            {
                switch (advertParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(t => t.Title);
                        break;
                }
            }

        }

        public AdvertsWithCategoriesSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.Category);
        }
    }
}