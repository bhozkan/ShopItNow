using Microsoft.EntityFrameworkCore;
using ShopItNow.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopItNow.WebUI.Repository.Concreate.EntityFramework
{
    public class ShopItNowContext : DbContext
    {
        public ShopItNowContext(DbContextOptions<ShopItNowContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(pk => new { pk.ProductId, pk.CategoryId });
        }
    }
}
