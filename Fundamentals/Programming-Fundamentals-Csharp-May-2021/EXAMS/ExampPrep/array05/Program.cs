using System;

namespace array05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int max1 = 0;
            int max2 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if(arr[i] > max2 && arr[i] < max1)
                {
                    max2 = arr[i];
                }
            }

            Console.Write("First largest = {0}\n", max1);
            Console.Write("Second largest = {0}", max2);
        }
    }
}
