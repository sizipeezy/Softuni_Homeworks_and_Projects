using System;

namespace _07RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int times = int.Parse(Console.ReadLine());

            PrintRepeat(input, times);
        }

        private static void PrintRepeat(string input, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(input);
            }
        }
    }
}
