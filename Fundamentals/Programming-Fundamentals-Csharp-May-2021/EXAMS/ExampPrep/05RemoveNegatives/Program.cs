using System;
using System.Collections.Generic;
using System.Linq;

namespace _05RemoveNegatives
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();

            nums.RemoveAll(w => w < 0);

            nums.Reverse();

            if (nums.Count == 0)
            {
                Console.WriteLine($"empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums));
            }

        }
    }
}
