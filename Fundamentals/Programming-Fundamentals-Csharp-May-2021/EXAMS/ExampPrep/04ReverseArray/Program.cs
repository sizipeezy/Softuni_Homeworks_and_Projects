using System;

namespace _04ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arr);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
