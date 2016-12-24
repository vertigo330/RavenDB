namespace NoSql.RavenDb.Domain.OrderItem
{
    public interface IOrderItem
    {
        string ProductId { get; set; }
        int Quantity { get; set; }
    }
}