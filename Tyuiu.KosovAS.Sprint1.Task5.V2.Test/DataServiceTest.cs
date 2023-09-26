using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;
using Tyuiu.KosovAS.Sprint1.Task5.V2.Lib;

namespace Tyuiu.KosovAS.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double t = 100;
            var res = 37;
            Assert.AreEqual(res, ds.FahrenheitToСelsius(t));
        }
    }
}
