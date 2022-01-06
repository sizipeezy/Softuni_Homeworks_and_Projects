using System;

namespace _03ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\",StringSplitOptions.RemoveEmptyEntries);

            string last = input[input.Length - 1];

            string[] arr = last.Split(".");

            string name = arr[0];
            string extension = arr[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}
