using System;
using System.Collections.Generic;
using System.Linq;

namespace _01SumNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> number = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(decimal.Parse)
                 .ToList();
            for (int i = 0; i < number.Count; i++)
            {
                int index = 0;
                if (i + 1 > number.Count - 1)
                {
                    break;

                }
                else
                {
                    index = i + 1;
                }

                if (number[i] == number[index])
                {
                    number[i] += number[index];
                    number.RemoveAt(index);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", number));
        }
    }
    
}
