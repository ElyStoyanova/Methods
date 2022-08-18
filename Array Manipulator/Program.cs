using System;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();

            while (command[0]!="end")
            {
                if (command[0]== "exchange")
                {
                    int index = int.Parse(command[1]);
                    inputArr = ExchangeByIndex(inputArr, index);
                }
                else if (command[0]=="max" || command[0]=="min")
                {
                    FindMinMax(inputArr, command[0], command[1]);
                }
                else
                {
                    FindNumbers(inputArr, command[0],  int.Parse(command[1]),command[2]);
                }
                command = Console.ReadLine().Split();
            }
        }

         static void FindNumbers(int[] inputArr, string v1, int v2, string v3)
        {
            throw new NotImplementedException();
        }

         static void FindMinMax( int[]inputArr, string maxOrMin, string evenOrOdd)
        {
            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (int input in inputArr)
            {
                if (maxOrMin == "min")
                {

                }
            }
            
        }

         static string[] ExchangeByIndex(int[] inputArr, int index)
        {
            throw new NotImplementedException();
        }
    }
}
