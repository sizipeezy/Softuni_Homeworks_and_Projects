using System;

namespace _02VowlesCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result = 0;
            result = printCount(input);
            Console.WriteLine(result);

        }

        private static int printCount(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (current == 'a')
                {
                    counter++;
                }
                else if (current == 'e')
                {
                    counter++;
                }
                else if (current == 'o')
                {
                    counter++;
                }
                else if (current == 'u')
                {
                    counter++;
                }
                else if (current == 'i')
                {
                    counter++;
                }
                else if (current == 'y')
                {
                    counter++;
                }
            }
            return counter;

        }
    }
}
