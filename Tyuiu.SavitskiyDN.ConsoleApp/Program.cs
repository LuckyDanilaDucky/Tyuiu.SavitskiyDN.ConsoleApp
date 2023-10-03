using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SavitskiyDN.ConsoleApp.Lab0.V0.Lib;
namespace Tyuiu.SavitskiyDN.ConsoleApp.Lab0.V0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите значение переменной K");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной W");
            int w = Convert.ToInt32(Console.ReadLine());

            DataService solve = new DataService();

            var result = solve.Add(k, w);

            Console.WriteLine("Сумма K + W = " + result);

            var result1 = solve.Minus(k, w);

            Console.WriteLine("Разность K - W = " + result1);

            var result2 = solve.Mult(k, w);

            Console.WriteLine("Произведение K * W = " + result2);

            var result3 = solve.Div(k, w);

            Console.WriteLine("Отношение K / W = " + result3);

            Console.ReadKey();

        }
    }
}


