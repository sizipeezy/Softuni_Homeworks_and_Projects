using System;
using System.Linq;

namespace arrayCountNEgatives
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();


            int[] result = arr.Where(n => n < 0).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
