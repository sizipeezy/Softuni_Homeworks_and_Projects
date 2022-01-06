using System;
using System.Collections.Generic;
using System.Linq;

namespace flowersWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liliesValue = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int[] rosesValues = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> lilies = new Stack<int>(liliesValue);

            Queue<int> roses = new Queue<int>(rosesValues);

            int wreaths = 0;
            int flowers = 0;
            //List<int> itemsLater = new List<int>();

            while (lilies.Count > 0&& roses.Count > 0)
            {
                int currentRose = roses.Peek();
                int currentLilie = lilies.Peek();

                if(currentLilie + currentRose == 15)
                {
                    wreaths++;
                    roses.Dequeue();
                    lilies.Pop();
                }
                else if(currentRose + currentLilie > 15)
                {
                    lilies.Pop();
                    int currLilie = currentLilie - 2;
                    lilies.Push(currLilie);

                }
                else if(currentRose + currentLilie < 15)
                {
                    flowers += currentRose + currentLilie;
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
