using System;
using System.Linq;

namespace _03ZigZagArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] result = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int item1 = result[0];
                int item2 = result[1];
                if (i % 2 == 0)
                {
                    arr1[i] = item1;
                    arr2[i] = item2;
                }
                else
                {
                    arr2[i] = item1;
                    arr1[i] = item2;
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
