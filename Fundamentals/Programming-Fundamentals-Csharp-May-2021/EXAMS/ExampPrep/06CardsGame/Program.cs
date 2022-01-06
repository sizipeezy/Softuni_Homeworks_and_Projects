using System;
using System.Collections.Generic;
using System.Linq;

namespace _06CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cards1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> cards2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();


            while (cards1.Count != 0 && cards2.Count != 0)
            {
                int p1cards = cards1[0];
                int p2cards = cards2[0];

                if (p1cards > p2cards)
                {
                    cards1.Add(p1cards);
                    cards1.Add(p2cards);
                }
                else if (p1cards < p2cards)
                {
                    cards2.Add(p2cards);
                    cards2.Add(p1cards);
                }

                cards1.RemoveAt(0);
                cards2.RemoveAt(0);

            }

            if (cards1.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {cards2.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {cards1.Sum()}");
            }
        }
    }
}
