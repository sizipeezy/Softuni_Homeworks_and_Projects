using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLootBoxValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var secondLootBoxValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> firstBox = new Queue<int>(firstLootBoxValues);

            Stack<int> secondBox = new Stack<int>(secondLootBoxValues);


            List<int> ClaimedItems = new List<int>();
            while (firstBox.Any() && secondBox.Any())
            {
                int currentSum = 0;
                int currentFirst = firstBox.Peek();
                int currentSecond = secondBox.Peek();

                currentSum = currentFirst + currentSecond;

                if(currentSum % 2 != 1)
                {
                    ClaimedItems.Add(currentSum);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    int moved = secondBox.Pop();
                    firstBox.Enqueue(moved);
                }

            }
            
            if(firstBox.Count <= 0)
            {
                Console.WriteLine($"First lootbox is empty");

            }
            else if(secondBox.Count <= 0)
            {
                Console.WriteLine($"Second lootbox is empty");
            }

            if(ClaimedItems.Sum() >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {ClaimedItems.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {ClaimedItems.Sum()}");
            }
        }
    }
}
