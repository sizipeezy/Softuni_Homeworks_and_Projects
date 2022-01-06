using System;
using System.Collections.Generic;
using System.Linq;

namespace _07AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split("|").ToList();

            items.Reverse();

            List<string> lists = new List<string>();
            List<string> result = lists;

            foreach (string item in items)
            {
                string[] nums = item.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (var it in nums)
                {
                    result.Add(it);
                }
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
