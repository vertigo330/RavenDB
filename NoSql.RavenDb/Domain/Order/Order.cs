using System;
using System.Collections.Generic;
using NoSql.RavenDb.Domain.OrderItem;

namespace NoSql.RavenDb.Domain.Order
{
    public class Order : IOrder
    {
        public string Id { get; set; }
        public string Customer { get; set; }
        public IList<IOrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<IOrderItem>();
        }
    }
}