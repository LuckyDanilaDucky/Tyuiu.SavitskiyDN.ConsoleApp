using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavitskiyDN.ConsoleApp.Lab2.V10.Lib;

namespace Tyuiu.SavitskiyDN.ConsoleApp.Lab2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressionV_3_1()
        {
            double x = 1;
            double y = 2;
            DataService ds = new DataService();

            double result = ds.SolveExpressV_3_1(x, y);

            result = Math.Round(result, 15);
            double wait = -13.14234385;

            Assert.AreEqual(result, wait);
        }

        [TestMethod]
        public void ValidExpressionV_3_2()
        {
            double x = 1;
            double y = 2; ;
            DataService ds = new DataService();

            double result = ds.SolveExpressV_3_2(x, y);

            result = Math.Round(result, 14);
            double wait = 5.380085143;

            Assert.AreEqual(result, wait);
        }
    }
}