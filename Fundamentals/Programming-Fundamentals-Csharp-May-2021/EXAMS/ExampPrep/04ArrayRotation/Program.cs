using System;
using System.Linq;

namespace _04ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation; i++)
            {
                int first = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    int current = arr[j];
                    arr[j - 1] = current;
                }
                arr[arr.Length - 1] = first;
            }
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
