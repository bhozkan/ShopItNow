using ShopItNow.WebUI.Entity;
using ShopItNow.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShopItNow.WebUI.Repository.Concreate.EntityFramework
{
    public class EFOrderRepository : IOrderRepository
    {
        private ShopItNowContext context;
        public EFOrderRepository(ShopItNowContext ctx)
        {
            context = ctx;
        }

        public void Add(Order entity)
        {
            context.Orders.Add(entity);
        }

        public void Delete(Order entity)
        {
            context.Orders.Remove(entity);
        }

        public void Edit(Order entity)
        {
            context.Entry<Order>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public IQueryable<Order> Find(Expression<Func<Order, bool>> predicate)
        {
            return context.Orders.Where(predicate);
        }

        public Order Get(int id)
        {
            return context.Orders.FirstOrDefault(o => o.OrderId == id);
        }

        public IQueryable<Order> GetAll()
        {
            return context.Orders;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
