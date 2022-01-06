using System;
using System.Linq;

namespace _08CondenseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            int[] condused = new int[array.Length - 1];

            if (array.Length == 1)
            {
                Console.WriteLine(array[0]);
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < condused.Length - i; j++)
                {
                    condused[j] = array[j] + array[j + 1];
                }
                array = condused;
            }
            Console.WriteLine(condused[0]);

        }
    }
}
