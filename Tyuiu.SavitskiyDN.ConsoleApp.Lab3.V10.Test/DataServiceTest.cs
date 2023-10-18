using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavitskiyDN.ConsoleApp.Lab3.V10.Lib;

namespace Tyuiu.SavitskiyDN.ConsoleApp.Lab3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetPoint()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 6;
            bool res = ds.GetPointShape(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
