namespace Core.Entities
{
    public class AdvertCategory
    {
        public int AdvertId { get; set; }
        public Advert Advert { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}