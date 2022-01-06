using System;
using System.Linq;

namespace _03RoundingNums
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(decimal.Parse)
                                    .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} => {Math.Round(nums[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
