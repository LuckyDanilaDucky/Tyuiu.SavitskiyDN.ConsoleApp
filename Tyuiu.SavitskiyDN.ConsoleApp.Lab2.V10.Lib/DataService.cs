using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SavitskiyDN.ConsoleApp.Lab2.V10.Lib
{
    public class DataService
    {
        public double SolveExpressV_3_1(double x, double y)
        {
            double result = 2 * (1 / Math.Tan(3 * x)) - (Math.Log(Math.Cos(x), Math.E) / Math.Log(1 + Math.Pow(x, 2), Math.E));
            return result;
        }

        public double SolveExpressV_3_2(double x, double y)
        {
            double result = (2 + Math.Pow((Math.Cos(x + y)), 2)) / 1 + Math.Abs((x - (3 * x)) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2))) + x * y;
            return result;
        }
    }
}