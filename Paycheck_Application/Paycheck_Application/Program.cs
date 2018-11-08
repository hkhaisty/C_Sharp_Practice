using System;

namespace Paycheck_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of paychecks you would like to process: \n");
            int paycheckAmount = Console.Read();

            Console.WriteLine("Enter the value for the first paycheck: \n");
            double paycheckValue = Console.Read();

            if (paycheckAmount > 1)
            {
                for (int i = 2; i < paycheckAmount; i++)
                {
                    Console.WriteLine("Enter the amount for paycheck #" + i);
                    paycheckValue += Console.Read();
                }

                Console.WriteLine("Your total is " + paycheckValue);
            }

            else
                Console.WriteLine("Your total is " + paycheckValue);

        }
    }
}
