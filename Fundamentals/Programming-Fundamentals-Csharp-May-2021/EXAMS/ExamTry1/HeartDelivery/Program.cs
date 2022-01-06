using System;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int jumpPosition = 0;
            string command = Console.ReadLine();

            while (command != "Love!")
            {
                string[] cmdArgs = command.Split();

                string firstCommand = cmdArgs[0];
                int index = int.Parse(cmdArgs[1]);

                jumpPosition += index;

                if(jumpPosition >= 0 && jumpPosition < arr.Length)
                {
                    arr[jumpPosition] -= 2;

                }
                else
                {
                    jumpPosition = 0;
                    arr[jumpPosition] -= 2;
                }


                if(arr[jumpPosition] == 0)
                {
                    Console.WriteLine($"Place {jumpPosition} has Valentine's day.");
                }
                else if(arr[jumpPosition] < 0)
                {
                    Console.WriteLine($"Place {jumpPosition} already had Valentine's day.");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {jumpPosition}.");
            int successCount = arr.Count(x => x == 0);
            int failCount = arr.Count(x => x > 0);

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
