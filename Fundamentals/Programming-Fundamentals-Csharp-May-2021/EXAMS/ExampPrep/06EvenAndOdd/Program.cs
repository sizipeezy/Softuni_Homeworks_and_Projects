using System;
using System.Linq;

namespace _06EvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            int Evensum = 0;
            int oddSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Evensum += arr[i];
                }
                else
                {
                    oddSum += arr[i];
                }
            }
            int result = Evensum - oddSum;

            Console.WriteLine(result);
        }
    }
}
