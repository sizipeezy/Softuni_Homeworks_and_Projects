using System;

namespace NegativeArraysElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter size of the array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine($"Enter {n} elements in the array");

           
            for (int i = 0; i < n; i++)
            {
                arr[i] += int.Parse(Console.ReadLine());

                

            }



            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    Console.Write(arr[i]);
                }
            }
            Console.WriteLine();
           
        }
    }
}
