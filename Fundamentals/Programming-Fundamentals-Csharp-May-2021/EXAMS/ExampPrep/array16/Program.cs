using System;
using System.Linq;

namespace array16
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(double.Parse)
                                   .ToArray();

            double[] result = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = (double)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item + " ");
            }

        }
    }
}
