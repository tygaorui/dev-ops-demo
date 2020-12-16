using System;
using System.Collections.Generic;
using System.Linq;

namespace Ordering.API.Queries
{
    public class Order
    {
        public long OrderNumber { get; set; }

        public DateTime Date { get; set; }

        public List<OrderItem> Items { get; set; }

        public decimal Total => Items.Sum(x => x.Total);

        public string Remark { get; set; }
    }

    public class OrderItem
    {
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Total => Quantity * UnitPrice;

        public string PictureUrl { get; set; }
    }
}
