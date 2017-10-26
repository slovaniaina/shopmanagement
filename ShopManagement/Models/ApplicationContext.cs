using System;
using Microsoft.EntityFrameworkCore;
namespace ShopManagement.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }

        public DbSet<Article> Article { get; set; }
    }
}
