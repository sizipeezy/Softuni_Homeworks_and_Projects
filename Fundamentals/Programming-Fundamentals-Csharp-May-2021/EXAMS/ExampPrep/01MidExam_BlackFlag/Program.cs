using System;

namespace _01MidExam_BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double dailyPlunder = double.Parse(Console.ReadLine());
            double expected = double.Parse(Console.ReadLine());

            double plunderBonus = 0;
            double battleLose = 0;

            double sumPlunder = 0;
            int counter = 0;
            for (int i = 0; i < days; i++)
            {
                sumPlunder += dailyPlunder;
                counter++;
                if (counter % 3 == 0)
                {
                    plunderBonus = 0.50 * dailyPlunder;
                    sumPlunder += plunderBonus;

                }

                if (counter % 5 == 0)
                {
                    battleLose = 0.30 * sumPlunder;
                    sumPlunder -= battleLose;
                }
            }
            if (sumPlunder > expected)
            {
                Console.WriteLine($"Ahoy! {sumPlunder:f2} plunder gained.");
            }
            else if (sumPlunder < expected)
            {
                double needed = (sumPlunder / expected) * 100;
                Console.WriteLine($"Collected only {needed:f2}% of the plunder.");
            }
        }
    }
}
