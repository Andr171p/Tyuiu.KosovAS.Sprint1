using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint1.Task7.V16.Lib;

namespace Tyuiu.KosovAS.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double Test_x = Math.PI;
            Assert.AreEqual(-0.172, ds.Calculate(Test_x));
        }
    }
}
