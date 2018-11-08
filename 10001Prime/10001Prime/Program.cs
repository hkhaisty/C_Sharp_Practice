using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeCount = 0;
            int i;
            int primeNumber = 0;

            do
            {
                for (i = 0; i < 30; i++)
                {

                    if ((!(i % 2).Equals(0) || !(i % 3).Equals(0) || !(i % 4).Equals(0) || !(i % 5).Equals(0) || !(i % 6).Equals(0) || !(i % 7).Equals(0) || !(i % 8).Equals(0) || !(i % 9).Equals(0)))
                    {
                     // primeNumber = i;
                        primeCount += 1;
                    }
                }

                }
                while (primeCount <= 5) ;

            Console.WriteLine(primeNumber);
            Console.WriteLine(primeCount);
            Console.ReadKey();
            }
    }
    }
