using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hatsSequence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            int[] scarfsSequence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            List<int> results = new List<int>();

            Stack<int> hats = new Stack<int>(hatsSequence);

            Queue<int> scarf = new Queue<int>(scarfsSequence);



            while (hats.Any() && scarf.Any())
            {
                int currentHat = hats.Peek();
                int currentScarf = scarf.Peek();

                if(currentScarf == currentHat)
                {
                    scarf.Dequeue();
                    int increment = hats.Pop() + 1;
                    hats.Push(increment);
                }

                else if(currentHat > currentScarf)
                {
                    int sum = currentScarf + currentHat;
                    results.Add(sum);
                    scarf.Dequeue();
                    hats.Pop();
                }
                else if(currentScarf > currentHat)
                {
                    hats.Pop();
                    continue;
                }
            }

            Console.WriteLine($"The most expensive set is: {results.Max()}");
            Console.WriteLine(string.Join(" ", results));

        }
    }
}
