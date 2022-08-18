using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSmollest(number1,number2,number3));
        }

         static int GetSmollest(int number1, int number2, int number3)
        {
            int smallest = 0;

            smallest = Math.Min(number1, Math.Min(number2, number3));

            return smallest;   
        }
    }
}
