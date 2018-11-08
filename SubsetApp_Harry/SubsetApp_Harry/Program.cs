using System;
using System.Text.RegularExpressions;

namespace SubsetApp_Harry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of values in set A, separated only by commas\n (ex: 1,2,3,4,5): ");
            String inputStringA = Console.ReadLine();
            string cleanedInputA = Regex.Replace(inputStringA, @"\s+", "");
            string[] A = cleanedInputA.Split(',');

            Console.WriteLine("Enter a list of values in set B, separated only by commas\n (ex: 1,2,3,4,5): ");
            String inputStringB = Console.ReadLine();
            string cleanedInputB = Regex.Replace(inputStringB, @"\s+", "");
            string[] B = cleanedInputB.Split(',');

            bool matches = true;
            foreach(string a in A)
            {
                bool foundA = false; 
                foreach(string b in B)
                {
                    if (b.CompareTo(a) == 0)
                    {
                        foundA = true;
                        break;
                    }
                } 
                if (!foundA)
                {
                    matches = false;
                    break;
                }
            }

            if (matches)
            {
                Console.WriteLine("Yes.");
            }

            else
            {
                Console.WriteLine("No.");
            }

            Console.ReadKey();
        }
    }
}

