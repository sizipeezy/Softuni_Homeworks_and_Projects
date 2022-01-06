using System;
using System.Linq;

namespace _03MidExam_HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                    .Split("@", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            int jumpPosition = 0;
            string input = Console.ReadLine();
            while (input != "Love!")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                int index = int.Parse(cmdArgs[1]);

                jumpPosition += index;
                if (jumpPosition >= 0 && jumpPosition < array.Length)
                {
                    array[jumpPosition] -= 2;
                }
                else
                {
                    jumpPosition = 0;
                    array[jumpPosition] -= 2;

                }


                if (array[jumpPosition] == 0)
                {
                    Console.WriteLine($"Place {jumpPosition} has Valentine's day.");
                }
                else if (array[jumpPosition] < 0)
                {
                    Console.WriteLine($"Place {jumpPosition} already had Valentine's day.");
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {jumpPosition}.");
            int successCount = array.Count(x => x == 0);
            int failCount = array.Count(x => x > 0);

            if (failCount == 0)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failCount} places.");
            }

        }
    }
}
