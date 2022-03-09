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
            double first = 0, second = 0;

            Console.WriteLine("Choices: " + "1, " + "2, " + "3, " + "4, " + "5");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice >= 1 && choice <=5)
            {
                Console.Write("Enter first number: ");
                first = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                second = Convert.ToInt32(Console.ReadLine());
            }

            if(choice == 1)
            {
                CS_Programs.Calculator calculate = new Calculator();
                double result = calculate.Sum(first, second);
                Console.WriteLine("The sum of two numbers are: " + result);
            }
            else if(choice == 2)
            {
                CS_Programs.Calculator calculate = new Calculator();
                double result = calculate.Difference(first, second);
                Console.WriteLine("The difference of two numbers are: " + result);
            }
            else if(choice == 3)
            {
                CS_Programs.Calculator calculate = new Calculator();
                double result = calculate.Product(first, second);
                Console.WriteLine("The product of two numbers are: " + result);
            }
            else if (choice == 4)
            {
                CS_Programs.Calculator calculate = new Calculator();
                double result = calculate.Quotient(first, second);
                Console.WriteLine("The quotient of two numbers are: " + result);
            }
            else if (choice == 5)
            {
                CS_Programs.Calculator calculate = new Calculator();
                double result = calculate.Remainder(first, second);
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
