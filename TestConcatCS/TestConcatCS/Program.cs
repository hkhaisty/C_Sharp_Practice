using System;

namespace TestConcatCS
{
    class Program
    {
        static void Main(string[] args)
        {

            String name, present, yourName;
            int age;

            Console.Write("What is the name of the gift giver? ");
            name = Console.ReadLine();

            Console.Write("What is the gift? ");
            present = Console.ReadLine();

            Console.Write("How old were you on your birthday? ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your name? ");
            yourName = Console.ReadLine();


            Console.WriteLine("\n\n");
            Console.WriteLine("Dear {0} ", name + "\n");
            Console.WriteLine("Thank you for the {0} .", present);
            Console.WriteLine("I can't believe I'm already {0} years old, but ", age);
            Console.WriteLine("it doesn't feel that much different than being " + (age - 1) + ".\n");
            Console.WriteLine("Sincerely, \n");
            Console.WriteLine(yourName);

            Console.ReadKey();


        }
    }
}
