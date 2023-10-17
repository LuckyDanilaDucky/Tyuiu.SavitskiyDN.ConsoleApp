using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SavitskiyDN.ConsoleApp.Lab1.V10.Lib;

namespace Tyuiu.SavitskiyDN.ConsoleApp.Lab1.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа #1 | Выполнил: Савицкий Д.Н. | НТм-22-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная работа #1                                                  *");
            Console.WriteLine("* Расчёты арифметических и математических выражений в C#                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Савицкий Данила Николаевич | НТм-22-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на С#, которая выполняет расчёты          *");
            Console.WriteLine("* арифметических и математических выражений.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 5;
            double y = 1;
            double a = -2;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("a = " + a);

            DataService ds = new DataService();

            double result1 = ds.SolveExpressV_3_1(x, y, a);
            double result2 = ds.SolveExpressV_3_2(x, y, a);

            result1 = Math.Round(result1, 13);
            result2 = Math.Round(result2, 12);

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