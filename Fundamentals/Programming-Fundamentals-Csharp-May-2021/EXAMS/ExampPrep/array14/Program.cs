using System;
using System.Linq;

namespace array14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            int[] result = arr.OrderByDescending(x => x).ToArray();

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
