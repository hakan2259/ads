using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class AdsContextSeed
    {
        public static async Task SeedAsync(AdsContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Categories.Any())
                {
                    var categoriesData = File.ReadAllText("../Infrastructure/Data/SeedData/categories.json");

                    var categories = JsonSerializer.Deserialize<List<Category>>(categoriesData);

                    foreach (var category in categories)
                    {
                        context.Categories.Add(category);
                    }
                    await context.SaveChangesAsync();
                }

                if (!context.Adverts.Any())
                {
                    var advertsData = File.ReadAllText("../Infrastructure/Data/SeedData/adverts.json");

                    var adverts = JsonSerializer.Deserialize<List<Advert>>(advertsData);

                    foreach (var advert in adverts)
                    {
                        context.Adverts.Add(advert);
                    }
                    await context.SaveChangesAsync();
                }
               
                
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<AdsContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}