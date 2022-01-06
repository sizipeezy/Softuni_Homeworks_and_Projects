using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            var bombEffectsValues = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var bombCasingValue = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> bombEffect = new Queue<int>(bombEffectsValues);
            Stack<int> bombCasing = new Stack<int>(bombCasingValue);

            int datura = 0;
            int cherry = 0;
            int smoke = 0;

            while (bombEffect.Any() && bombCasing.Any())
            {
                int currentBomb = bombEffect.Peek();
                int currentCase = bombCasing.Peek();

                int currentSum = 0;

                currentSum = currentBomb + currentCase;

                if (datura >= 3 && cherry>= 3 && smoke >= 3)
                {
                    break;
                }

                if (currentSum == 40)
                {
                    datura++;
                    bombEffect.Dequeue();
                    bombCasing.Pop();
                }
                else if(currentSum == 60)
                {
                    cherry++;
                    bombEffect.Dequeue();
                    bombCasing.Pop();
                }
                else if(currentSum == 120)
                {
                    smoke++;
                    bombEffect.Dequeue();
                    bombCasing.Pop();
                }
                else if (currentCase <= 0)
                {
                    bombCasing.Pop();
                }
                else
                {
                    int deacreased = bombCasing.Pop() - 5;
                    bombCasing.Push(deacreased);
               }
            }
            if (datura >= 3 && smoke >= 3 && cherry >= 3)
            {
                Console.WriteLine($"Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine($"You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffect.Count <= 0)
            {
                Console.WriteLine($"Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffect)}");
            }


            if (bombCasing.Count <= 0)
            {
                Console.WriteLine($"Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");
        }
    }
}
