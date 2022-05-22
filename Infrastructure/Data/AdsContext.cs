
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AdsContext : DbContext
    {
        public AdsContext(DbContextOptions<AdsContext> options): base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<Advert>().Property(a => a.Id).IsRequired();
            modelBuilder.Entity<Advert>().Property(a => a.Title).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Advert>().Property(a => a.Description).IsRequired().HasMaxLength(500);
            modelBuilder.Entity<Advert>().Property(a => a.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Advert>().Property(a => a.PictureUrl).IsRequired();
            modelBuilder.Entity<Advert>().Property(a => a.Address).IsRequired().HasMaxLength(250);

            modelBuilder.Entity<Category>().Property(c => c.Id).IsRequired();
            modelBuilder.Entity<Category>().Property(c => c.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Category>().Property(c => c.Description).HasMaxLength(250);

            modelBuilder.Entity<AdvertCategory>()
            .HasKey(ac => new {ac.CategoryId,ac.AdvertId});
            modelBuilder.Entity<AdvertCategory>()
            .HasOne(ac => ac.Advert)
            .WithMany(a => a.AdvertCategories)
            .HasForeignKey(ac => ac.AdvertId);
            modelBuilder.Entity<AdvertCategory>()
            .HasOne(ac => ac.Category)
            .WithMany(c => c.AdvertCategories)
            .HasForeignKey(ac => ac.CategoryId);
        }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}