using System;
using System.Collections.Generic;

namespace Chap11Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
                sum += numbers[i];
            Console.WriteLine("The sum is " + sum);

            List<string> names = new List<string>() { "Bob", "Carol", "Ted", "Alice" };

            for (int i = 0; i < names.Count; i++)
                Console.WriteLine(names[i]);

            //Console.WriteLine(numbers[0] + ", " + numbers[1]);

            Console.ReadKey();
        }
    }
}
