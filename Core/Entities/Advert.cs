using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Advert : BaseEntity
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool IsApproved { get; set; }
        public DateTime AdvertDate { get; set; }
        public ICollection<AdvertCategory> AdvertCategories { get; set; }
    }
}