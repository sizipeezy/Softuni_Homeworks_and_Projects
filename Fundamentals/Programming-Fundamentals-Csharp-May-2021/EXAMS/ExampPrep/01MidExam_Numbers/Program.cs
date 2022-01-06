using System;
using System.Collections.Generic;
using System.Linq;

namespace _01MidExam_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            double average = 0;


            average = arr.Sum() / (double)arr.Count;

            var nums = arr.Where(x => x > average).ToArray().Count();

            if (arr.Count == 0)
            {
                Console.WriteLine("no");
                return;
            }
            else if (arr.Count < 5)
            {
                Console.WriteLine($"less than 5 numbers");
            }
            else
            {
                var result = arr.OrderByDescending(x => x).Where(x => x > average).Take(5).ToArray();

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
