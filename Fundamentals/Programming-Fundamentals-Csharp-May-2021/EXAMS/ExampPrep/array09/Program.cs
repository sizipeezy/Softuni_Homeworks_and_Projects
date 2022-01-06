using System;
using System.Linq;

namespace array09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(current == arr[j])
                    {
                        Console.WriteLine(current + " ");
                        counter++;
                    }

                }
            }
        }
    }
}
