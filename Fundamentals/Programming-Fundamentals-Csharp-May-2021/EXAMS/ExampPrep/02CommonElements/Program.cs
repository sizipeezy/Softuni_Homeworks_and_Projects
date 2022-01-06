using System;

namespace _02CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] arr2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in arr2)
            {
                
                for (int i = 0; i < arr1.Length; i++)
                {
                    if(item == arr1[i])
                    {
                        Console.Write(item + " ");
                    }
                }
            }
        }
    }
}
