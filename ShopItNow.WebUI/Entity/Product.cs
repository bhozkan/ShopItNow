using System;
using System.Collections.Generic;
using System.Text;

namespace ShopItNow.WebUI.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public int CategoryId { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
