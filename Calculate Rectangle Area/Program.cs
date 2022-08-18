using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengh = double.Parse(Console.ReadLine());
            double hight = int.Parse(Console.ReadLine());
            double area = CalculateArea(lengh, hight);

            Console.WriteLine(area);
        }

        static double CalculateArea(double lengh, double hight)
        {
            return lengh * hight;
        }  
    }
}
