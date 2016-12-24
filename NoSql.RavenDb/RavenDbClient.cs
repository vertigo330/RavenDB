using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NoSql.RavenDb.Domain.Order;
using NoSql.RavenDb.Domain.OrderItem;
using Raven.Client.Document;

namespace NoSql.RavenDb
{
    public class RavenDbClient
    {
        private static DocumentStore _store;

        public RavenDbClient()
        {
            InitialiseRavenDb();
        }

        private static void InitialiseRavenDb()
        {
            _store = new DocumentStore { Url = "http://localhost:8080" };
            _store.Initialize();
        }

        public void SaveOrder()
        {
            var order = new Order
                            {
                                Customer = "Jonathan Patton",
                                Id = "7",
                                OrderItems = new List<IOrderItem>
                                                 {
                                                     new OrderItem
                                                         {
                                                             ProductId = "Les Paul",
                                                             Quantity = 1
                                                         },
                                                     new OrderItem
                                                         {
                                                             ProductId = "Ernie Ball Strings",
                                                             Quantity = 6

                                                         }
                                                 }
                            };

            using (var session = _store.OpenSession())
            {
                session.Store(order);
                session.SaveChanges();
            }
        }
    }
}
