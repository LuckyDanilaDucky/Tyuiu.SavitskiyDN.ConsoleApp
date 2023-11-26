using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskiyDN.ConsoleApp.Lab6.V10.Lib;
namespace Tyuiu.SavitskiyDN.ConsoleApp.Lab6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;

            valueWaitArray = new double[len];

            valueWaitArray[0] = -9796193.0;
            valueWaitArray[1] = -645175.1;
            valueWaitArray[2] = -31082.9;
            valueWaitArray[3] = -878.8;
            valueWaitArray[4] = -11.2;
            valueWaitArray[5] = 1.0;
            valueWaitArray[6] = 4.5;
            valueWaitArray[7] = 11.6;
            valueWaitArray[8] = 26.0;
            valueWaitArray[9] = 61.0;
            valueWaitArray[10] = 154.9;


            double[] res;
            res = new double[len];

            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}