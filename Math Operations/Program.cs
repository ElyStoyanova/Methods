using System;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operator =Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(a,@operator,b));
        }

        static double Calculate(int a, string @operator, int b)
        {
            double sum = 0;

            switch (@operator)
            {
                case "+":sum = a + b;
                    break;
                case "-":
                    sum = a -b;
                    break;
                case "*":
                    sum = a *b;
                    break;
                case "/":
                    sum = a / b;
                    break;
            }
            return sum;
        }
    }
}
