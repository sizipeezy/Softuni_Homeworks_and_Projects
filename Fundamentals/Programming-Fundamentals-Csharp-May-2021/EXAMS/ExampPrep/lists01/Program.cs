using System;
using System.Collections.Generic;
using System.Linq;

namespace lists01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();

            

            for (int i = 0; i < nums.Count / 2; i++)
            {
                nums[i] += nums[nums.Count - 1];
                nums.RemoveAt(nums.Count - 1);
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
