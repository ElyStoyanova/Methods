using System;
using System.Linq;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower(); ;
           CountOfVowels(word);
        }

         static void CountOfVowels(string word)
        {
            Console.WriteLine(word.Count(letter=>"aouei".Contains(letter)));

           /* int count = 0;

            foreach (char letter in word)
            {
                if ("aouei".Contains(letter))
                {
                    count++;
                }
            }
            Console.WriteLine(count);*/
        }
    }
}
