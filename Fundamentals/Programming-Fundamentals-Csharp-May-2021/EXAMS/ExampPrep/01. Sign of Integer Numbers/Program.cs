using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                printNegative(n);
            }
            else if (n > 0)
            {
                printPositive(n);

            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }

        private static void printPositive(int n)
        {
            Console.WriteLine($"The number {n} is positive.");
        }

        private static void printNegative(int n)
        {
            Console.WriteLine($"The number {n} is negative.");
        }
    }

}