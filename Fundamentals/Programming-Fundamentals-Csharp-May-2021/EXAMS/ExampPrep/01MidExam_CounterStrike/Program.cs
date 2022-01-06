using System;

namespace _01MidExam_CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            bool isWin = true;
            int wons = 0;
            int battles = 0;
            while (input != "End of battle")
            {
                battles++;
                int distance = int.Parse(input);
                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wons} won battles and {energy} energy");
                    isWin = false;
                    break;
                }

                wons++;
                energy -= distance;

                

                if(battles % 3 == 0)
                {
                    energy += wons;
                }


               
                input = Console.ReadLine();

            }
            if (isWin)
            {
                Console.WriteLine($"Won battles: {wons}. Energy left: {energy}");
            }
        }
    }
}
