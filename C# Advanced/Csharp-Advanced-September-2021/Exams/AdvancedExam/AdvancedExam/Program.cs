using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedExam
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            char[] consonants = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

           string pork = "pork";
           string flour = "flour";
           string pear = "pear";
           string olive = "olive";


            List<char> porks = new List<char>();
            List<char> flours = new List<char>();
            List<char> pears = new List<char>();
            List<char> olives = new List<char>();


            Queue<char> vowls = new Queue<char>(vowels);
            Stack<char> cons = new Stack<char>(consonants);

            while (vowls.Any() && cons.Any())
            {
                char currentVow = vowls.Peek();
                char currentCons = cons.Peek();

                int findCounter1 = 0;
                int findCounter2 = 0;

                if (pork.Contains(currentVow) || pork.Contains(currentCons))
                {
                    porks.Add(currentVow);
                    porks.Add(currentCons);
                    vowls.Dequeue();
                    vowls.Enqueue(currentVow);
                    cons.Pop();

                }
                else if (flour.Contains(currentVow) || flour.Contains(currentCons))
                {
                    flours.Add(currentVow);
                    flours.Add(currentCons);
                    vowls.Dequeue();
                    vowls.Enqueue(currentVow);
                    cons.Pop();
                }
                else if (pear.Contains(currentVow) || pear.Contains(currentCons))
                {
                    pears.Add(currentVow);
                    pears.Add(currentCons);
                    vowls.Dequeue();
                    vowls.Enqueue(currentVow);
                    cons.Pop();
                }
                else if (olive.Contains(currentVow) || olive.Contains(currentCons))
                {
                    olives.Add(currentVow);
                    olives.Add(currentCons);
                    vowls.Dequeue();
                    vowls.Enqueue(currentVow);
                    cons.Pop();
                }
            }
        }
    }
}
