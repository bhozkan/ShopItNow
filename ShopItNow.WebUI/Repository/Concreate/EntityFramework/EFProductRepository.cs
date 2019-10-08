using Microsoft.EntityFrameworkCore;
using ShopItNow.WebUI.Entity;
using ShopItNow.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ShopItNow.WebUI.Repository.Concreate.EntityFramework
{
    public class EFProductRepository : EFGenericRepository<Product>, IProductRepository
    {
        public EFProductRepository(ShopItNowContext context)
            :base(context)
        {

        }

        public ShopItNowContext shopItNowContext
        {
            get { return context as ShopItNowContext; }
        } 
        public List<Product> GetTop5Products()
        {
            return shopItNowContext.Products.OrderByDescending(p => p.ProductId).Take(5).ToList();

            
        }
    }
}
