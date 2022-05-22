using System.Collections.Generic;

namespace Core.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<AdvertCategory> AdvertCategories { get; set; }
    }
}