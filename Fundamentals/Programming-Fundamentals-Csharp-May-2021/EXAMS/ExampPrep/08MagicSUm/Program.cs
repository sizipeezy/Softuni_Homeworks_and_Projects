using System;
using System.Linq;

namespace _08MagicSUm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int curr = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(curr + arr[j] == n)
                    {
                        Console.WriteLine($"{curr} {arr[j]}");
                    }
                }
            }
        }
    }
}
