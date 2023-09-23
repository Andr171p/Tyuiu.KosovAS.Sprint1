using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint1.Task3.V2.Lib;

namespace Tyuiu.KosovAS.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double pp = 3;
            int ap = 4;
            double pn = 4.5;
            int an = 2;
            var res = ds.PurchaseAmount(pn, an, pp, ap);
            Assert.AreEqual(21, res);

        }
    }
}
