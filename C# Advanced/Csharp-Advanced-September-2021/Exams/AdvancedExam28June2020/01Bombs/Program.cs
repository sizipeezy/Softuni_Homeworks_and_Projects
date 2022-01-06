using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombEffectsCount = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bombCasingCount = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int daturaBomb = 0;
            int CherryBomb = 0;
            int SmokeDecoyBomb = 0;

            Queue<int> bombEffect = new Queue<int>(bombEffectsCount);
            Stack<int> bombCasing = new Stack<int>(bombCasingCount);

            int sumOfEffect = 0;
            while (bombEffect.Any() && bombCasing.Any())
            {
                int currentBombEffect = bombEffect.Peek();
                int currentCasing = bombCasing.Peek();
                sumOfEffect = currentBombEffect + currentCasing;


                if(daturaBomb >=3 && CherryBomb >= 3 && SmokeDecoyBomb >= 3)
                {
                    break;
                }
                if(sumOfEffect == 40)
                {
                    daturaBomb++;
                    bombCasing.Pop();
                    bombEffect.Dequeue();
                }
                else if(sumOfEffect == 60)
                {
                    CherryBomb++;
                    bombCasing.Pop();
                    bombEffect.Dequeue();
                }
                else if(sumOfEffect == 120)
                {
                    SmokeDecoyBomb++;
                    bombCasing.Pop();
                    bombEffect.Dequeue();
                }
                else if(currentCasing <= 0)
                {
                    bombCasing.Pop();
                }
                else
                {
                    int current = bombCasing.Peek() - 5;
                    bombCasing.Pop();
                    bombCasing.Push(current);

                }

            }


            if(daturaBomb >=3 && SmokeDecoyBomb >= 3 && CherryBomb >= 3)
            {
                Console.WriteLine($"Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine($"You don't have enough materials to fill the bomb pouch.");
            }

            if(bombEffect.Count <= 0)
            {
                Console.WriteLine($"Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ",bombEffect)}");
            }


            if (bombCasing.Count <= 0)
            {
                Console.WriteLine($"Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }

            Console.WriteLine($"Cherry Bombs: {CherryBomb}");
            Console.WriteLine($"Datura Bombs: {daturaBomb}");
            Console.WriteLine($"Smoke Decoy Bombs: {SmokeDecoyBomb}");
        }
    }
}
