
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            var hatsNums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var sequence = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> scarfs = new Queue<int>(sequence);
            Stack<int> hats = new Stack<int>(hatsNums);
            List<int> clothes = new List<int>();

            while (hats.Any() && scarfs.Any())
            {
                int currentHat = hats.Peek();
                int currentScarft = scarfs.Peek();

                if (currentHat == currentScarft)
                {
                    scarfs.Dequeue();
                    hats.Push(hats.Pop() + 1);
                }

                else if (scarfs.Peek() > hats.Peek())
                {
                    hats.Pop();
                }
                else if (scarfs.Peek() < hats.Peek())
                {
                    clothes.Add(hats.Pop() + scarfs.Dequeue());
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"The most expensive set is: {clothes.Max()}");
            Console.WriteLine(string.Join(" ", clothes));
        }
    }
}
