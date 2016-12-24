using System.Collections.Generic;
using NoSql.RavenDb.Domain.OrderItem;

namespace NoSql.RavenDb.Domain.Order
{
    public interface IOrder
    {
        string Id { get; set; }
        string Customer { get; set; }
        IList<IOrderItem> OrderItems { get; set; }
    }
}