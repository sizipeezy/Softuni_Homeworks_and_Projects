using System;
using System.Linq;

namespace array12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();


            
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}\t", arr[i]);
            }

        }
    }
}
