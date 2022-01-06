using System;
using System.Linq;

namespace array10
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                int curr = arr[i];
                for (int j = i + 1; j < size; j++)
                {
                    if (curr == arr[i])
                    {
                        for (int k = j; k < size - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }

                        /* Decrement size after removing duplicate element */
                        size--;

                        /* If shifting of elements occur then don't increment j */
                        j--;
                    }
                }
            }
            Console.Write("\nArray elements after deleting duplicates : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0}\t", arr[i]);
            }
            Console.ReadLine();
        }
    }

}
