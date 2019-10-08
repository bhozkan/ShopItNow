using ShopItNow.WebUI.Entity;
using ShopItNow.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShopItNow.WebUI.Repository.Concreate.EntityFramework
{
    public class EFCategoryRepository : EFGenericRepository<Category>, ICategoryRepository
    {
        public EFCategoryRepository(ShopItNowContext context)
            :base(context)
        {
                
        }

        public ShopItNowContext shopItNowContext
        {
            get { return context as ShopItNowContext; }
        }

        public Category GetByName(string name)
        {
            return shopItNowContext.Categories.Where(c => c.CategoryName == name).FirstOrDefault();
        }
    }
}
