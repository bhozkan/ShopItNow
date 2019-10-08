using ShopItNow.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopItNow.WebUI.Repository.Concreate.EntityFramework
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly ShopItNowContext dbContext;

        public EFUnitOfWork(ShopItNowContext _dbContext)
        {
            dbContext = _dbContext ?? throw new ArgumentNullException("dbContext can not be null.");
        }

        private IProductRepository _products;
        private ICategoryRepository _categories;


        public IProductRepository Products
        {
            get
            {
                return _products ?? (_products = new EFProductRepository(dbContext));
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new EFCategoryRepository(dbContext));
            }
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }

        public int SaveChanges()
        {
            try
            {
                return dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
