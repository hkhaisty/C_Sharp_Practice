using System;

namespace Chap10Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            double temperature;
            Console.WriteLine("Enter a Fahrenheit temperature: ");
            temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(temperature + " F. equals " + ftoc(temperature) + " C.");

            double temperature2;
            Console.WriteLine("\nEnter a Celsius temperature: ");
            temperature2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(temperature2 + " C. equals " + ctof(temperature2) + " F.");

            double temperature3;
            char scale;

            Console.WriteLine("\nEnter a temperature to convert: ");
            temperature3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a scale to convert to (f/c): ");
            scale = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("The converted temperature is " + convert(temperature3, scale));



            Console.ReadKey();
        }

        static double convert(double temp, char scale)
        {
            if (scale == 'f')
                return ctof(temp);
            else if (scale == 'c')
                return ftoc(temp);
            else
                return -1;
        }

        static double ftoc(double temp)
        {
            return (temp - 32.0) * (5.0 / 9.0);
        }

        static double ctof(double temp)
        {
            return (temp * 9.0 / 5.0) + (32.0);
        }
    }
}
