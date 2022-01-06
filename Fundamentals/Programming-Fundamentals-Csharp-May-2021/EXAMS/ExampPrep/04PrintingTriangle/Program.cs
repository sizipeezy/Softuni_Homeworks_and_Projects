using System;

namespace _04PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            printingTriangle(input);
        }

        private static void print(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        private static void printingTriangle(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                print(1, i);
            }

            for (int i = input - 1; i >= 1; i--)
            {
                print(1, i);
            }
        }
    }
}
