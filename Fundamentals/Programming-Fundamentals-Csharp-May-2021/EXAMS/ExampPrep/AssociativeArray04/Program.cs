using System;
using System.Linq;

namespace AssociativeArray04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int[] sorted = nums.OrderByDescending(x => x)
                               .Take(3)
                               .ToArray();

            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}
