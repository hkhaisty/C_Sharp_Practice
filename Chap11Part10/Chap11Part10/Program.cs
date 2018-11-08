using System;
using System.Collections.Generic;

namespace Chap11Part10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            BuildList(numbers);
            Display(numbers);
            int max = 0;

            //for (int i = 1; i < numbers.Count; ++i)
            //    if (numbers[i] > numbers[max])
            //        max = i;
            Console.WriteLine("The maximum value is " + numbers[maximum(numbers)]);
            Console.ReadKey();
                
        }

        static int maximum(List<int> lyst)
        {
            int max = 0;
            for (int i = 1; i < lyst.Count; ++i)
                if (lyst[i] > lyst[max])
                    max = i;
            return max;
        }

        static void Display(List<int> lyst)
        {
            for (int i = 0; i < 10; ++i)
                Console.Write(lyst[i] + " ");
            Console.WriteLine();
        }

        static void BuildList(List<int> lyst)
        {
            Random rand = new Random();
            for (int i = 1; i <= 10; ++i)
                lyst.Add(rand.Next(1, 101));
        }
    }
}
