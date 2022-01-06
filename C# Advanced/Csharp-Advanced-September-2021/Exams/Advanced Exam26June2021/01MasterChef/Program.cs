using System;
using System.Collections.Generic;
using System.Linq;

namespace _01MasterChef
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ingredientsNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int[] freshnessNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            Queue<int> ingredients = new Queue<int>(ingredientsNums);
            Stack<int> freshness = new Stack<int>(freshnessNums);

            int dippingSauces = 0, greenSalads = 0, chocolateCakes = 0, lobsters = 0;

            while (ingredients.Any() && freshness.Any())
            {
                int currentIngredient = ingredients.Peek();
                int currentFreshness = freshness.Peek();
                var freshnessValue = currentIngredient * currentFreshness;
                if(currentIngredient == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }


                if(freshnessValue == 150)
                {
                    dippingSauces++;
                    freshness.Pop();
                    ingredients.Dequeue();
                }
                else if(freshnessValue == 250)
                {
                    greenSalads++;
                    freshness.Pop();
                    ingredients.Dequeue();
                }
                else if(freshnessValue == 300)
                {
                    chocolateCakes++;
                    freshness.Pop();
                    ingredients.Dequeue();
                }
                else if(freshnessValue == 400)
                {
                    lobsters++;
                    freshness.Pop();
                    ingredients.Dequeue();
                }
                else
                {
                    
                    freshness.Pop();
                    currentIngredient += 5;
                    ingredients.Enqueue(currentIngredient);
                    ingredients.Dequeue();

                }
                

            }
            if (dippingSauces >0  && greenSalads > 0 && chocolateCakes >0 && lobsters >0)
            {
                Console.WriteLine($"Applause! The judges are fascinated by your dishes!");
                Console.WriteLine($"# Chocolate cake --> {chocolateCakes}");
                Console.WriteLine($"# Dipping sauce --> {dippingSauces}");
                Console.WriteLine($"# Green salad --> {greenSalads}");
                Console.WriteLine($"# Lobster --> {lobsters}");
            }
            else
            {
                Console.WriteLine($"You were voted off. Better luck next year.");
                if (ingredients.Sum() > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
                }
                if (chocolateCakes > 0)
                {
                    Console.WriteLine($"# Chocolate cake --> {chocolateCakes}");

                }
                if (dippingSauces > 0)
                {
                    Console.WriteLine($"# Dipping sauce --> {dippingSauces}");
                }
                if(greenSalads > 0)
                {
                    Console.WriteLine($"# Green salad --> {greenSalads}");
                }
                if(lobsters> 0)
                {
                    Console.WriteLine($"# Lobster --> {lobsters}");
                }
            }
        }
    }
}
