using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(ColculateToPower(number,power));
        }

         static double ColculateToPower(double number, int power)
        {
            double result = Math.Pow(number, power);

            return result;
        }
    }
}
