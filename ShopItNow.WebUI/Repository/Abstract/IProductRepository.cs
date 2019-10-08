using ShopItNow.WebUI.Entity;
using System.Linq;

namespace ShopItNow.WebUI.Repository.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
