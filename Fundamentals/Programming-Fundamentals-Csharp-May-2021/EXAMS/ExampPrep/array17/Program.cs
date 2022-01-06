using System;
using System.Linq;

namespace array17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                  .ToArray();

            int rotation = arr.Length / 2;
            for (int i = 0; i < rotation; i++)
            {
                var oldItem = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = oldItem;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
