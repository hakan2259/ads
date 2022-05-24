using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class AdvertsWithCategoriesSpecification : BaseSpecification<Advert>
    {
        public AdvertsWithCategoriesSpecification()
        {
            AddInclude(x => x.Category);
        }

        public AdvertsWithCategoriesSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.Category);
        }
    }
}