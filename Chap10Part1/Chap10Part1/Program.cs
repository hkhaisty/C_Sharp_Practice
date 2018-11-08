using System;

namespace Chap10Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 12;
            Console.WriteLine(num + " squared is " + square(num));
            Console.ReadKey();
        }


        static double square(double number)
        {
            return number * number;
        }
        
    }
}
