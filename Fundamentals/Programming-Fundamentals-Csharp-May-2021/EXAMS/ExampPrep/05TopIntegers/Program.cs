using System;
using System.Linq;

namespace _05TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            bool isBigger = true;
            for (int i = 0; i < arr.Length; i++)
            {
                int curr = arr[i];
                for (int j = i + 1; j <arr.Length; j++)
                {
                    if(curr <= arr[j])
                    {
                        isBigger = false;
                        break;
                    }
                }
                if(isBigger)
                {
                    Console.Write(curr + " ");
                }
                isBigger = true;
            }
        }
       
    }
}
