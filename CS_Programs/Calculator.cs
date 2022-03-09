using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programs
{
    class Calculator
    {
        public double Sum(double first, double second)
        {
            double sum = first + second;
            return sum;
        }
        public double Difference(double first, double second)
        {
            double diff = first - second;
            return diff;
        }
        public double Product(double first, double second)
        {
            double product = first * second;
            return product;
        }
        public double Quotient(double first, double second)
        {
            double quotient = first / second;
            return quotient;
        }
        public double Remainder(double first, double second)
        {
            double remains = first % second;
            return remains;
        }
    }
}
