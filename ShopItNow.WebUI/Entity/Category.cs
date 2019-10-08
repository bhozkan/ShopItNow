using ShopItNow.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopItNow.WebUI.Entity
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
