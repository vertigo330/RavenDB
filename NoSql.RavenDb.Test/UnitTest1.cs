using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NoSql.RavenDb.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanSaveOrderObject()
        {
            var client = new RavenDbClient();
            client.SaveOrder();
        }
    }
}
