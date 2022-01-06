using System;

namespace ExamRetake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cities = int.Parse(Console.ReadLine());

            string name = string.Empty;
            double income = 0;
            double expen = 0;

            double currentSum = 0;
            double total = 0;

            for (int i = 1; i <= cities; i++)
            {
                name = Console.ReadLine();
                income = double.Parse(Console.ReadLine());
                expen = double.Parse(Console.ReadLine());


                currentSum = income - expen;

                
                if(i % 3 == 0)
                {
                    double moreExpend = 0.5 * expen;
                    currentSum -= moreExpend;
                }

                if(i % 5 == 0)
                {
                    double percentIncome = 0.10 * income;
                    currentSum -= percentIncome;
                }

                Console.WriteLine($"In {name} Burger Bus earned {currentSum:f2} leva.");
                total += currentSum;

            }

            Console.WriteLine($"Burger Bus total profit: {total:f2} leva.");
        }
    }
}
