using System;

namespace NoSql.RavenDb.Domain.Product
{
    public class Product :IProduct
    {
        public string Id { get; set;}
        public string Name { get; set;}
        public decimal Cost { get; set;}
        
    }
}