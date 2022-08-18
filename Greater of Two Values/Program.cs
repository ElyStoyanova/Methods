using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();

            switch (inputType)
            {
                case "int":
                    int number1 = int.Parse(Console.ReadLine());
                    int number2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(number1,number2));
                    break;
                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(char1, char2));
                    break;
                case "string":
                    string string1 = Console.ReadLine();
                    string string2 = Console.ReadLine();
                    Console.WriteLine(GetMax(string1, string2));
                    break;
            }
        }

         static int GetMax(int first, int second)
        {
            int result = 0;
            result = Math.Max(first, second);
            return result;
        }
        static char GetMax(char first, char second)
        {
            if (first>second)
            {
                return first;
            }
                return second;
        }
        static string GetMax(string first, string second)
        {
            int result = first.CompareTo(second);
            if (result>0)
            {
                return first;
            }
            return second;
        }
    }
}
