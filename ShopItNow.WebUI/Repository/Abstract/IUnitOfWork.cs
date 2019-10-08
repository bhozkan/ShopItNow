using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopItNow.WebUI.Repository.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }

        int SaveChanges();
    }
}
