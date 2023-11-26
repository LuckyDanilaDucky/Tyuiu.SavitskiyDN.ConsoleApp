using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SavitskiyDN.ConsoleApp.Lab5.V10.Lib
{
    public class DataService
    {
        public double GetSum(int n)
        {
            double S = 0;
            for (int x = 1; x <= n; x++)
            {
                S = S + ((Math.Sin(Math.Pow(x, 5)) + Math.Pow(x, 3)) / (Math.Cos(Math.Pow(x, 2))));
            }
            return Math.Round(S, 3);


        }
    }
}