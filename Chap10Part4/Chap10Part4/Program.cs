using System;

namespace Chap10Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            String date;
            String day;
            String month;
            String year;

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("What is the day of the month? ");
            day = Console.ReadLine();

            Console.WriteLine("What month is it? ");
            month = Console.ReadLine();

            Console.WriteLine("What year is it? ");
            year = Console.ReadLine();

            date = month + "/" + day + "/" + year;

            Heading(name, date);
            Console.ReadKey();
        }

        static void Heading(String name, String date)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("*          " + name + "          *");
            Console.WriteLine("*         " + date + "          *");
            Console.WriteLine("*****************************");
        }
    }
}
