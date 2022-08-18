using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
           
            Characters_in_Range(letter1, letter2);
        }

        static void Characters_in_Range(char letter1, char letter2)
        {
            int startChar = Math.Min(letter1, letter2);
            int endChar = Math.Max(letter1, letter2);

            for (int i = startChar+1; i < endChar; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
