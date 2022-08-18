using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           

            for (int i = 1; i <=number; i++)
            {
                if (DiviseByEight(i) && LeastOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        static bool LeastOneOddDigit(int i)
        {
            int oddNumber = i;

            while (oddNumber > 0)
            {
                int newNumber = oddNumber % 10;

                if (newNumber % 2 != 0)
                {
                    return true;
                    break;
                }
                oddNumber /= 10;
            }
            return false;
        }
         static bool DiviseByEight(int i)
        {
            int sum = 0;
            int oldNumber = i;

            while (oldNumber>0)
            {
               int  newNumber = oldNumber % 10;
                sum += newNumber;
                oldNumber /= 10;
            }
            if (sum%8==0)
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
