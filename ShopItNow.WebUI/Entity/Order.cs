using System;
using System.Collections.Generic;
using System.Text;

namespace ShopItNow.WebUI.Entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
