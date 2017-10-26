using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ShopManagement.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationContext>>()))
            {
                // Look for any articles.
                if (context.Article.Any())
                {
                    return;   // DB has been seeded
                }

                context.Article.AddRange(
                    new Article
                     {
                         Name = "Calligraphe", 
                    Type = "Cahier",
                    Price = 7
                     },

                    new Article
                    {
                        Name = "Bic",
                        Type = "Pen",
                        Price = 13
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
