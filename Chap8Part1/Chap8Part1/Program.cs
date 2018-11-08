using System;

namespace Chap8Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean flag;

            String userName;
            String userPassword;

            Console.Write("Enter your username: ");
            userName = Console.ReadLine();

            Console.Write("Enter your password: ");
            userPassword = Console.ReadLine();

            flag = (userName == "Maggie" && userPassword == "password");
            Console.WriteLine("Input is " + flag);
            Console.ReadKey();
        }
    }
}
