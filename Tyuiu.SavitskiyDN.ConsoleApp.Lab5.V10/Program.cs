using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SavitskiyDN.ConsoleApp.Lab5.V10.Lib;
namespace Tyuiu.SavitskiyDN.ConsoleApp.Lab5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n;
            double S;
            Console.WriteLine("Введите число N (кол-во повторений):");
            n = Convert.ToInt32(Console.ReadLine());
            S = ds.GetSum(n);
            Console.WriteLine("Конечная сумма равна " + S);
            Console.ReadKey();
        }
    }
}