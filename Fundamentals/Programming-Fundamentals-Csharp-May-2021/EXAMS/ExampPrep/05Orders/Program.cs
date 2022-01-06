using System;

namespace _05Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());



            switch (input)
            {
                case "coffee":
                    coffee(amount);
                    break;
                case "water":
                    water(amount);
                    break;
                case "coke":
                    coke(amount);
                    break;
                case "snacks":
                    snacks(amount);
                    break;
                default:
                    break;
            }

        }

        static void coffee(double amount)
        {
            double price = 1.50;

            price = 1.50;
            double result = amount * price;
            Console.WriteLine($"{result:F2}");

        }
        static void water(double amount)
        {
            double price = 1.00;

            price = 1.00;
            double result = amount * price;
            Console.WriteLine($"{result:F2}");

        }

        static void coke(double amount)
        {
            double price = 1.40;

            price = 1.40;
            double result = amount * price;
            Console.WriteLine($"{result:F2}");

        }
        static void snacks(double amount)
        {
            double price = 2.00;

            price = 2.00;
            double result = amount * price;
            Console.WriteLine($"{result:F2}");

        }
    }
    
}
