using System;
using System.Collections.Generic;
using System.Linq;

namespace _01FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liliesCount = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] rosesCount = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            Stack<int> lilies = new Stack<int>(liliesCount);
            Queue<int> roses = new Queue<int>(rosesCount);

            int wreaths = 0;
            int flowers = 0;

            while (lilies.Any() && roses.Any())
            {
                int currentLilie = lilies.Peek();
                int currentRose = roses.Peek();

                int currentSum = currentRose + currentLilie;

                if(currentSum == 15)
                {
                    wreaths++;
                    lilies.Pop();
                    roses.Dequeue();

                }
                else if(currentSum > 15)
                {
                    
                    lilies.Pop();
                    int current = currentLilie - 2;
                    lilies.Push(current);
                    
                }
                else if(currentSum < 15)
                {
                    flowers += currentSum;
                    lilies.Pop();
                    roses.Dequeue();
                }
            }

            wreaths += flowers / 15;
            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }


        }
    }
}
