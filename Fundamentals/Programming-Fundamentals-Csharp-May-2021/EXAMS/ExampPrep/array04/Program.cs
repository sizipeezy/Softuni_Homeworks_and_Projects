using System;
using System.Linq;

namespace array04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
        }
    }
}
