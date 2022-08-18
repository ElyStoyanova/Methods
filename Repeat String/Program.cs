using System;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string combination = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(combination,repeat));
        }

         static string RepeatString(string combination, int repeat)
        {
            string result = string.Empty;

            for (int i = 0; i < repeat; i++)
            {
                result = result + combination;
            }
            return result;
           
        }
    }
}
