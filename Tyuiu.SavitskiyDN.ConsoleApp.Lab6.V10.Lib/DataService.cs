using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SavitskiyDN.ConsoleApp.Lab6.V10.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)

        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
             
                y = x + Math.Pow(Math.E, x) + ((Math.Sin(Math.Pow(x, 5)) + Math.Pow(x, 3))/(Math.Pow(3, x))) + ((Math.Pow(x, 5))/Math.Pow(5, x));

                valueArray[count] = y;
                count++;
                

            }
            return valueArray;

        }
    }
}