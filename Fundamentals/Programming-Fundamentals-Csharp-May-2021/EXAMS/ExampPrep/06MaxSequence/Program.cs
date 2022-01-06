using System;
using System.Linq;

namespace _06MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            int bestCount = 0;
            int bestIndex = 0;

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int curr = arr[i];
                count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(curr == arr[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if(count > bestCount)
                {
                    bestCount = count;
                    bestIndex = i;
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
