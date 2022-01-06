using System;

namespace _04CaeserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (char item in input)
            {
                var curr = (char)(item + 3);
                Console.Write(curr);
            }
        }
    }
}
