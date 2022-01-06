using System;
using System.Collections.Generic;
using System.Linq;

namespace _05BombNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();


            int[] bombs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = bombs[0];
            int power = bombs[1];

            for (int i = 0; i < nums.Count; i++)
            {
                int current = nums[i];
                if (bomb == current)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;
                    if(startIndex <0)
                    {
                        startIndex = 0;
                    }

                    if(endIndex > nums.Count - 1)
                    {
                        endIndex = nums.Count - 1;
                    }

                    int indexRemove = endIndex - startIndex + 1;

                    nums.RemoveRange(startIndex, indexRemove);
                    i = startIndex - 1;
                }
            }
            Console.WriteLine(string.Join(" ", nums.Sum()));
        }
    }
}
