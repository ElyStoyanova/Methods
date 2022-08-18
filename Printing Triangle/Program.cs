using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            for (int i = 1; i <=lenght; i++)
            {
                PrintLine(1, i);
            }

            for (int j = lenght-1;  j>=1; j--)
            {
                PrintLine(1, j);
            }
        }

         static void PrintLine(int start, int end)
        {
            for (int i = start; i <=end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
