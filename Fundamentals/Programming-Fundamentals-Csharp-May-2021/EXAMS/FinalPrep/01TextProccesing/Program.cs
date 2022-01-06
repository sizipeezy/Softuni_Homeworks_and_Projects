using System;
using System.Linq;

namespace _01TextProccesing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string curr = input[i];
                if (isValid(curr))
                {
                    Console.WriteLine(curr);
                }
            }
        }

        private static bool isValid(string curr)
        {
            return curr.Length >= 3 && curr.Length <= 16
                 && curr.All(x => char.IsLetterOrDigit(x))
                 || curr.Contains("-") || curr.Contains("_");
        }
    }
}
