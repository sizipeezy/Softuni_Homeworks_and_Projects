using System;
using System.Linq;

namespace array13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            int element = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int curr = arr[i];
                if(curr == element)
                {
                    Console.WriteLine(arr[i]+ " ");
                }
            }
        }
    }
}
