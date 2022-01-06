using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();
            
            nums.Reverse();

            nums.RemoveAll(x => x < 0);

            if(nums.Count == 0)
            {
                Console.WriteLine($"empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ",nums));
            }

        }
    }
}
