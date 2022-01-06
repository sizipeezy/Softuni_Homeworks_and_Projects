using System;
using System.Linq;

namespace array08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Enter element to delete: ");
            int element = int.Parse(Console.ReadLine());

            
            if(element >= arr.Length && element < 0)
            {
                Console.WriteLine($"Invalid!");
            }
            else
            {
                for (int i = element - 1; i < size - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                size -= 1;
            }

            Console.WriteLine(string.Join(" ", arr));


        }
    }
}
