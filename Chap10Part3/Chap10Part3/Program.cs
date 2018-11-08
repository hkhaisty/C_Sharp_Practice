using System;

namespace Chap10Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            char letter;

            Console.Write("enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (isEven(num))
                Console.WriteLine(num + " is even.");
            else
                Console.WriteLine(num + " is odd.");

            Console.Write("enter a letter: ");
            letter = Convert.ToChar(Console.ReadLine());

            if (isVowel(letter))
                Console.WriteLine(letter + " is a vowel.");
            else
                Console.WriteLine(letter + " is not a consonant.");

            Console.ReadKey();
            
        }

        static Boolean isEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        static Boolean isVowel (char letter)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                return true;
            else
                return false;
        }
    }
}
