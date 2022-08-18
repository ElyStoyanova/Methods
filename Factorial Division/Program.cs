using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int number = firstNumber;
            double firstFactoriel = ColculateFactoriel(number);
            number = secondNumber;
            double fsecondFactoriel = ColculateFactoriel(number);

            double divideResult = firstFactoriel / fsecondFactoriel;
            Console.WriteLine($"{divideResult:f2}");
        }

         static double ColculateFactoriel(int number)
        {
            double factorielResult = 1;

            for (int i = 1; i <= number; i++)
            {
                factorielResult *= i;
            }

            return factorielResult;
        }
    }
}
