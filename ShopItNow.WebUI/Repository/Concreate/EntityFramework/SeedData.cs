using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopItNow.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopItNow.WebUI.Repository.Concreate.EntityFramework
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<ShopItNowContext>();

            context.Database.Migrate();

            if (!context.Products.Any())
            {
                var products = new[]
                {
                    new Product()
                    {
                        ProductName = "XBOX 360",
                        ProductPrice =2345 
                    },
                    new Product()
                    {
                        ProductName = "XBOX One Controller",
                        ProductPrice =350
                    },
                    new Product()
                    {
                        ProductName = "XBOX Kinect",
                        ProductPrice =1000
                    },
                    new Product()
                    {
                        ProductName = "FIFA 20",
                        ProductPrice =350
                    }

                };

                context.Products.AddRange(products);

                var categories = new[]
                {
                    new Category(){CategoryName = "Electronics"},
                    new Category(){CategoryName = "Game"},
                    new Category(){CategoryName = "Accesories"}
                };

                context.Categories.AddRange(categories);

                var productCategories = new[]
                {
                    new ProductCategory(){Product= products[0],Category=categories[0]},
                    new ProductCategory(){Product= products[1],Category=categories[0]},
                    new ProductCategory(){Product= products[1],Category=categories[1]},
                    new ProductCategory(){Product= products[2],Category=categories[0]},
                    new ProductCategory(){Product= products[2],Category=categories[1]},
                    new ProductCategory(){Product= products[3],Category=categories[2]},
                };

                context.AddRange(productCategories);
                context.SaveChanges();
            }

        }
    }
}
