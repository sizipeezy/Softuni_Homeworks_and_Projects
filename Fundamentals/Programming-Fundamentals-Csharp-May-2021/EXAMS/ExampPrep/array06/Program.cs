using System;
using System.Linq;

namespace array06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(i % 2 == 0)
                {
                    sumEven++;
                }
                else
                {
                    sumOdd++;
                }
            }

            Console.WriteLine($"Odd sum: {sumOdd}");
            Console.WriteLine($"Even sum : {sumEven}");

        }
    }
}
