using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liquidsNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] ingredientsNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int breadCount = 0;
            int cakeCount = 0;
            int pastryCount = 0;
            int fruitPieCount = 0;


            Queue<int> liquid = new Queue<int>(liquidsNums);
            Stack<int> ingredient = new Stack<int>(ingredientsNums);

            int currentSum = 0;
            while (liquid.Any() && ingredient.Any())
            {

                int currentLiquid = liquid.Peek();
                int currentIngredient = ingredient.Peek();
                currentSum = currentLiquid + currentIngredient;

                if (breadCount >= 1 && cakeCount >= 1 && pastryCount >= 1 && fruitPieCount >= 1)
                {
                    break;
                }

                if (currentSum == 25)
                {
                    breadCount++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else if (currentSum == 50)
                {
                    cakeCount++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else if (currentSum == 75)
                {
                    pastryCount++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else if (currentSum == 100)
                {
                    fruitPieCount++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }

                else
                {
                    liquid.Dequeue();
                    int curr = ingredient.Pop();

                    ingredient.Push(curr + 3);
                }


            }


            if (breadCount >= 1 && cakeCount >= 1 && pastryCount >= 1 && fruitPieCount >= 1)
            {
                Console.WriteLine($"Wohoo! You succeeded in cooking all the food!");
            }

            else
            {
                Console.WriteLine($"Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquid.Count <= 0)
            {
                Console.WriteLine($"Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquid)})");
            }


            if (ingredient.Count <= 0)
            {
                Console.WriteLine($"Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredient)}");
            }

            Console.WriteLine($"Bread: {breadCount}");
            Console.WriteLine($"Cake: {cakeCount}");
            Console.WriteLine($"Fruit Pie: {fruitPieCount}");
            Console.WriteLine($"Pastry: {pastryCount}");
        }
    }
}
