using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int multiplySum = GetMultiplyDigits(evenSum,oddSum);
            Console.WriteLine(multiplySum);
        }

        static int GetMultiplyDigits(int evenSum, int oddSum)
        {
            int multiplay = evenSum * oddSum;
            return multiplay;
        }

         static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            int digits = number;
            while (digits > 0)
            {
               int currentDigit = digits% 10;
                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;
                }
                digits /= 10;
            }
            return sum;
        }

         static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            int digits = number;
            while (digits > 0)
            {
                int currentDigit = digits % 10;
                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }
                digits /= 10;
            }
            return sum;
        }
    }
}
