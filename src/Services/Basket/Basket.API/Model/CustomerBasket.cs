using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace Basket.API.Model
{
    public class CustomerBasket
    {
        public CustomerBasket() { }

        public CustomerBasket(int customerId,string customerName,List<BasketItem> items)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Items = items;
            UpdateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public ObjectId Id { get; set; }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public List<BasketItem> Items { get; set; }

        public string UpdateTime { get; set; }
    }

    public class BasketItem
    {
        public BasketItem() { }

        public BasketItem(string name,string longName,int qty,decimal originPrice,decimal unitPrice)
        {
            ProductName = name;
            ProductLongName = longName;
            Quantity = qty;
            OriginPrice = originPrice;
            UnitPrice = unitPrice;
            TotalPrice = qty * unitPrice;
        }

        public string ProductName { get; set; }

        public string ProductLongName { get; set; }

        public int Quantity { get; set; }

        public decimal OriginPrice { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
