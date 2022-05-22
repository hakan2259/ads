using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class AdvertConfiguration : IEntityTypeConfiguration<Advert>
    {
        public void Configure(EntityTypeBuilder<Advert> builder)
        {
            // builder.Property(a => a.Id).IsRequired();
            // builder.Property(a => a.Title).IsRequired().HasMaxLength(100);
            // builder.Property(a => a.Description).IsRequired().HasMaxLength(500);
            // builder.Property(a => a.Price).HasColumnType("decimal(18,2)");
            // builder.Property(a => a.PictureUrl).IsRequired();
            // builder.Property(a => a.Address).IsRequired().HasMaxLength(250);
            



        }
    }
}