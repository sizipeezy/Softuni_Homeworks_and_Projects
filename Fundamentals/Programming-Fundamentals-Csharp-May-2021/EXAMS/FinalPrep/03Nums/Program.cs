using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();
            double average = 0;



            if (nums.Count == 0 || nums.Count <= 1)
            {
                Console.WriteLine("No");
                return;
            }

            average = nums.Sum() / (double)nums.Count;
            if (nums.Count < 5)
            {
                Console.WriteLine($"Less than 5 numbers");
            }
            else
            {
                var result = nums.OrderByDescending(x => x).Where(x => x > average).Take(5).ToArray();

                Console.WriteLine(string.Join(" ", result));
            }
        }
        
    }
}
