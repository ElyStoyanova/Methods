using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOperation = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            /*"add", "multiply", "subtract", "divide*/

            switch (inputOperation)
            {
                case "add":Add(firstNum, secondNum);
                    break;
                case "multiply":Multiplay(firstNum, secondNum);
                    break;
                case "subtract":Subtract(firstNum, secondNum);
                    break;
                case "divide":Divide(firstNum, secondNum);
                    break;
            }
        }

         static void Divide(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum/secondNum);
        }

         static void Subtract(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum-secondNum);

        }

        static void Multiplay(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum*secondNum);

        }

         static void Add(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum+secondNum);

        }
    }
}
