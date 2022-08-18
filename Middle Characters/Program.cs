using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            if (inputString.Length%2!=0)
            {
                char output = inputString[inputString.Length / 2];
                Console.WriteLine(output);
            }
            else
            {
                char output1 = inputString[(inputString.Length / 2)-1];
                char output2 = inputString[(inputString.Length / 2)];
                Console.WriteLine($"{output1}{output2}");
            }
        }
    }
}
