using System;
using System.Linq;

namespace _06EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();


            bool isFound = false;
            for (int curr = 0; curr < arr.Length; curr++)
            {
                int leftSum = 0;
                for (int i = curr + 1; i < arr.Length; i++)
                {
                    leftSum += arr[i];
                }

                int rightSum = 0;
                for (int i = curr - 1; i >= 0; i--)
                {
                    rightSum += arr[i];
                }

                if(leftSum==rightSum)
                {
                    Console.WriteLine(curr);
                    isFound = true;
                    break;
                }
            }
            if(!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
