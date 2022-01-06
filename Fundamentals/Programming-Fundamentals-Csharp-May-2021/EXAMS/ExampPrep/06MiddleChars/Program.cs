using System;

namespace _06MiddleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 == 0)
            {
                string output = GetMiddleChar(input);
                Console.WriteLine(output);

            }
            else
            {
                string oddOutPut = GetSecondChar(input);
                Console.WriteLine(oddOutPut);
            }

        }

        private static string GetSecondChar(string input)
        {
            int i = input.Length / 2;
            string chars = input.Substring(i, 1);
            return chars;

        }

        private static string GetMiddleChar(string input)
        {
            int i = input.Length / 2;
            string chars = input.Substring(i - 1, 2);
            return chars;
        }
    }
}
