using System;

namespace _01ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalPrice = 0;
            double totalPriceWithTaxes = 0;
            while (true)
            {
                if(input == "special" || input == "regular")
                {
                    break;
                }

                string[] cmdArgs = input.Split();
                double prices = double.Parse(cmdArgs[0]);

                if(prices <= 0)
                {
                    Console.WriteLine($"Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }

                totalPrice += prices;

                input = Console.ReadLine();
            }
            if(input == "special")
            {
                totalPriceWithTaxes = totalPrice * 0.20;
                double finalPrice = totalPrice + totalPriceWithTaxes;

                double discount = finalPrice * 0.10;
                finalPrice -= discount;
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {totalPriceWithTaxes:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {finalPrice:f2}$");



            }
            else if (input == "regular")
            {
                totalPriceWithTaxes = totalPrice * 0.20;
                double finalPrice = totalPrice + totalPriceWithTaxes;
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {totalPriceWithTaxes:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {finalPrice:f2}$");
            }
        }
        
    }
}
