using ShopItNow.WebUI.Entity;
using ShopItNow.WebUI.Repository.Abstract;
using System.Linq;

namespace ShopItNow.WebUI.Repository.Concreate.EntityFramework
{
    class EFProductRepository : IProductRepository
    {
        private ShopItNowContext context;

        public EFProductRepository(ShopItNowContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
