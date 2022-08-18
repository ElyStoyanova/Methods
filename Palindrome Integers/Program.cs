using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input!="END")
            {
                int number = int.Parse(input);
              
                Console.WriteLine(CheakPalindromInt(number));
                input = Console.ReadLine();
            }
        }

        static bool CheakPalindromInt(int number)
        {
            int oldNumber = number;
            int reverseNumber = 0;
            int newNumber = 0;

            while (number>0)
            {
                newNumber = number % 10;
                reverseNumber = reverseNumber * 10 + newNumber;
                number /= 10;
            }

            if (oldNumber==reverseNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
