using System;

namespace Chap12Part6
{

    class Calculator
    {
        private double result;

        public Calculator()
        {
            result = 0;
        }
        public double Add(double operand1, double operand2)
        {
            result = operand1 + operand2;
            return result;
        }

        public double Subtract(double operand1, double operand2)
        {
            result = operand1 - operand2;
            return result;
        }

        public double Multiply(double operand1, double operand2)
        {
            result = operand1 * operand2;
            return result;
        }

        public double Divide(double operand1, double operand2)
        {
            result = operand1 / operand2;
            return result;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Calculator calc = new Calculator();
                Console.WriteLine(calc.Add(1, 1));
                Console.WriteLine(calc.Subtract(12.1, 1.1));
                Console.WriteLine(calc.Multiply(12, 12));
                Console.WriteLine(calc.Subtract(15, 4));
                Console.ReadKey();
            }
        }
    }
}
