using System;
using System.Collections.Generic;
using System.Linq;

namespace _02GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();
            int rotation = nums.Count / 2;

            for (int i = 0; i < rotation; i++)
            {
                nums[i] += nums[nums.Count - 1];
                nums.Remove(nums[nums.Count - 1]);
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
