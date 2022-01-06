using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArray01
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(double.Parse)
                                   .ToArray();

            var counts = new SortedDictionary<double, int>();

            foreach (int item in nums)
            {
                if(counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts.Add(item, 1);
                }
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
