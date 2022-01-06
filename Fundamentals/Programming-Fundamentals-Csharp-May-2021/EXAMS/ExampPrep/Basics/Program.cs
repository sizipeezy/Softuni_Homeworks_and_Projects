using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if(n == 1)
            {
                Console.WriteLine(arr[0]);
            }
            else if(n == 2)
            {
                Console.WriteLine(arr[1]);
            }
            else if(n == 3)
            {
                Console.WriteLine(arr[2]);
            }
            else if(n == 4)
            {
                Console.WriteLine(arr[3]);
            }
            else if(n == 5)
            {
                Console.WriteLine(arr[4]);
            }
            else if(n == 6)
            {
                Console.WriteLine(arr[5]);
            }
            else if(n == 7)
            {
                Console.WriteLine(arr[6]);
            }
            else
            {
                Console.WriteLine($"Invalid day!");
            }

        }
    }
}
