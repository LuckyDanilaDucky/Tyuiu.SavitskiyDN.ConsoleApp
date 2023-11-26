using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.SavitskiyDN.ConsoleApp.Lab5.V10.Lib
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSum()
        {
            DataService ds = new DataService();
            int n = 10;
            double S = ds.GetSum(n);
            double wait = 2884.282;
            Assert.AreEqual(wait, S);



        }
    }
}