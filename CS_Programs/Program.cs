using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Programs;

namespace CS_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = 0, second = 0;

            Console.WriteLine("Choices: " + "\n1 - Addition, " + "\n2 - Substraction, " + "\n3 - Multiplication, " + "\n4 - Division, " + "\n5 - Remainder");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice >= 1 && choice <=5)
            {
                Console.Write("Enter first number: ");
                first = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                second = Convert.ToInt32(Console.ReadLine());

            }

            CS_Programs.Calculator calculate = new Calculator(first, second);

            if (choice == 1)
            {
                double result = calculate.Sum();
                Console.WriteLine("The sum of two numbers are: " + result);
            }
            else if(choice == 2)
            {
                double result = calculate.Difference();
                Console.WriteLine("The difference of two numbers are: " + result);
            }
            else if(choice == 3)
            {
                double result = calculate.Product();
                Console.WriteLine("The product of two numbers are: " + result);
            }
            else if (choice == 4)
            {
                double result = calculate.Quotient();
                Console.WriteLine("The quotient of two numbers are: " + result);
            }
            else if (choice == 5)
            {
                double result = calculate.Remainder();
                Console.WriteLine("The remainder of two numbers are: " + result);
            }
            else
            {
                Console.WriteLine("No such choice available!");
            }

            Console.ReadKey();
        }
    }
}
