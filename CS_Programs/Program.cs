using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Programs;

namespace CS_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            CS_Programs.UserInput calculate = new UserInput();
            int result = calculate.Sum(first, second);

            Console.Write("The sum of two numbers are: " + result);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
