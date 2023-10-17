using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SavitskiyDN.ConsoleApp.Lab2.V10.Lib;

namespace Tyuiu.SavitskiyDN.ConsoleApp.Lab2.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа #2 | Выполнил: Савицкий Д.Н. | НТм-22-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная работа #2                                                  *");
            Console.WriteLine("* Расчёты математических выражений в C#                                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Савицкий Данила Николаевич | НТм-22-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на С#, которая выполняет расчёты          *");
            Console.WriteLine("* математических выражений в С#.                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной x");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной y");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x = " + x);
            Console.WriteLine("x = " + y);

            DataService ds = new DataService();

            double result1 = ds.SolveExpressV_3_1(x, y);
            double result2 = ds.SolveExpressV_3_2(x, y);

            result1 = Math.Round(result1, 15);
            result2 = Math.Round(result2, 14);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" 1-е выражение: " + result1);
            Console.WriteLine(" 2-е выражение: " + result2);
            Console.WriteLine("***************************************************************************");


            Console.ReadKey();
        }
    }
}
