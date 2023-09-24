using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint1.Task4.V21.Lib;

namespace Tyuiu.KosovAS.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.2, res);
        }
    }
}
