using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ingredientValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] freshnessValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int dippingSauce = 0;
            int greenSalad = 0;
            int chocolateCake = 0;
            int lobster = 0;

            Queue<int> ingredient = new Queue<int>(ingredientValues);
            Stack<int> freshness = new Stack<int>(freshnessValues);


            int freshnessLevel = 0;
            while (ingredient.Any() && freshness.Any())
            {
                int currentIngredient = ingredient.Peek();
                int currentFreshness = freshness.Peek();

                freshnessLevel = currentIngredient * currentFreshness;

               
                if(freshnessLevel == 150)
                {
                    dippingSauce++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else if(freshnessLevel == 250)
                {
                    greenSalad++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else if(freshnessLevel == 300)
                {
                    chocolateCake++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else if(freshnessLevel == 400)
                {
                    lobster++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else if(currentIngredient <= 0)
                {
                    ingredient.Dequeue();
                    continue;
                }
                else
                {
                    freshness.Pop();
                    int current = ingredient.Dequeue() + 5;
                    ingredient.Enqueue(current);

                }
            }

            if (dippingSauce >= 1 && greenSalad >= 1 && chocolateCake >= 1 && lobster >= 1)
            {
                Console.WriteLine($"Applause! The judges are fascinated by your dishes!");
                Console.WriteLine($"# Chocolate cake --> {chocolateCake}");
                Console.WriteLine($"# Dipping sauce --> {dippingSauce}");
                Console.WriteLine($"# Green salad --> {greenSalad}");
                Console.WriteLine($"# Lobster --> {lobster}");
            }
            else
            {
                Console.WriteLine($"You were voted off. Better luck next year.");
                if (ingredient.Sum() > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredient.Sum()}");
                }
                if (chocolateCake > 0)
                {
                    Console.WriteLine($"# Chocolate cake --> {chocolateCake}");

                }
                if (dippingSauce > 0)
                {
                    Console.WriteLine($"# Dipping sauce --> {dippingSauce}");
                }
                if (greenSalad > 0)
                {
                    Console.WriteLine($"# Green salad --> {greenSalad}");
                }
                if (lobster > 0)
                {
                    Console.WriteLine($"# Lobster --> {lobster}");
                }
            }


        }
    }
}
