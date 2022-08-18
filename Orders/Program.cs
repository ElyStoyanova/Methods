using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfProduct = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            ColculateSum(kindOfProduct, quantity);
        }

         static void ColculateSum(string kindOfProduct, int quantity)
        {
            decimal totalPrice = 0;

            switch (kindOfProduct)
            { 
                case "coffee":
                    totalPrice = quantity * 1.50m;
                    break;
                case "water":
                    totalPrice = quantity * 1.00m;
                    break;
                case "coke":
                    totalPrice = quantity * 1.40m;
                    break;
                case "snacks":
                    totalPrice = quantity * 2.00m;
                    break;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
