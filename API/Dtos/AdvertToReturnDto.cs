using System;

namespace API.Dtos
{
    public class AdvertToReturnDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool IsApproved { get; set; }
        public DateTime AdvertDate { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}