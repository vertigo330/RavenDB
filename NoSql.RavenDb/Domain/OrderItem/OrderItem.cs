using System;

namespace NoSql.RavenDb.Domain.OrderItem
{
    public class OrderItem :IOrderItem
    {
        public string ProductId{get; set;}

        public int Quantity { get; set; }
    }
}