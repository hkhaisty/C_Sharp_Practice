using System;

namespace Chap10Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            double amt, disc;
            Console.WriteLine("Enter the original cost: ");
            amt = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the discount in whole number form: ");
            disc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your final cost is: " + discount(amt, disc));
            Console.ReadKey();
            
        }

        static double discount(double amount, double percent)
        {
            return (amount - (amount * (percent / 100)));
        }
    }
}
