using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programs
{
    public class Calculator
    {
        private readonly double first;
        private readonly double second;

        public Calculator(double first, double second)
        {
            this.first = first;
            this.second = second;
        }
        public double Sum()
        {
            double sum = this.first + this.second;
            return sum;
        }
        public double Difference()
        {
            double diff = this.first - this.second;
            return diff;
        }
        public double Product()
        {
            double product = this.first * this.second;
            return product;
        }
        public double Quotient()
        {
            double quotient = this.first / this.second;
            return quotient;
        }
        public double Remainder()
        {
            double remains = this.first % this.second;
            return remains;
        }
    }
}
