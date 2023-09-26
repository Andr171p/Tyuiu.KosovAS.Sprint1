using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint1.Task6.V18.Lib;

namespace Tyuiu.KosovAS.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strTest = "1234";
            Assert.AreEqual(true, ds.CheckNumber(strTest));
        }
    }
}
