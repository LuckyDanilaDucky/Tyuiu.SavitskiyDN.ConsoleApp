using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.SavitskiyDN.ConsoleApp.Lab4.V10.Lib
{
    public class DataService
    {
        public bool GetPointShape(double x, double y)
        {
            bool res;
            if ((y <= -x && y >= Math.Pow(x, 2) - 2) || (y <= x && y >= Math.Pow(x, 2) - 2))

            {
                res = true;

            }

            else
            {
                res = false;
            };

            return res;
        }
    }
}