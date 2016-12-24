namespace NoSql.RavenDb.Domain.Product
{
    public interface IProduct
    {
        string Id { get; set;}
        string Name { get; set; }
        decimal Cost { get; set; }
    }
}