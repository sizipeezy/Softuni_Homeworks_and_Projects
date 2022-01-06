using System;
using System.Collections.Generic;
using System.Linq;

namespace _01cooking

{
    class Program
    {
        static void Main(string[] args)
        {
            var liquidsValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var ingredientsValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> liquid = new Queue<int>(liquidsValues);
            Stack<int> ingredient = new Stack<int>(ingredientsValues);


            int bread = 0;
            int cake = 0;
            int pastry = 0;
            int fruitPie = 0;


            while (liquid.Any() && ingredient.Any())
            {
                int currentSum = 0;

                int currentLiquid = liquid.Peek();
                int currentIngredient = ingredient.Peek();

                currentSum = currentLiquid + currentIngredient;

                if(currentSum == 25)
                {
                    bread++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else if(currentSum == 50)
                {
                    cake++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else if(currentSum == 75)
                {
                    pastry++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else if(currentSum == 100)
                {
                    fruitPie++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else
                {
                    liquid.Dequeue();
                    int curr = ingredient.Pop() + 3;
                    ingredient.Push(curr);
                }
            }

            if (bread >= 1 && cake >= 1 && pastry >= 1 && fruitPie >= 1)
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

            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {pastry}");
        }
    }
}
