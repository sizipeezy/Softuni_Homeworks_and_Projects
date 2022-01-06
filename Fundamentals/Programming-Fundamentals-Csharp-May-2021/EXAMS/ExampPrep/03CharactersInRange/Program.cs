using System;

namespace _03CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            printBetween(a, b);

        }

        private static void printBetween(char a, char b)
        {
            if (a > b)
            {
                char first = a;
                a = b;
                b = first;
            }
            for (int i = a + 1; i < b; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
