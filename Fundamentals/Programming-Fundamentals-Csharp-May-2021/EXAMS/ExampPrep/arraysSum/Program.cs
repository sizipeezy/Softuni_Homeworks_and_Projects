using System;
using System.Linq;

namespace arraysSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            Console.WriteLine(arr.Sum());
        }
    }
}
