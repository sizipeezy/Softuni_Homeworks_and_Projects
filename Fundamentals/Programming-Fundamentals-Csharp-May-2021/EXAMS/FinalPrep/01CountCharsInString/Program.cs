using System;
using System.Collections.Generic;

namespace _01CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            var output = new Dictionary<char, int>();

            foreach (char ch in input)
            {
                if (ch != ' ')
                {
                    if (!output.ContainsKey(ch))
                    {
                        output.Add(ch, 1);
                    }
                    else
                    {
                        output[ch]++;
                    }
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
