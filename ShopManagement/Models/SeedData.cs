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
                InitializeArticle(context);
                InitializeShop(context);
                context.SaveChanges();
            }
        }

        static void InitializeArticle(ApplicationContext context)
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
        }

        static void InitializeShop(ApplicationContext context){
            if(context.Shop.Any()){
                return;
            }

            context.Shop.AddRange(
                new Shop{
                    Name = "Super U",
                    Location = "New York"
                },
                new Shop{
                    Name = "Jumbo",
                    Location = "Phoenix"
                }
            );
        }
    }
}
