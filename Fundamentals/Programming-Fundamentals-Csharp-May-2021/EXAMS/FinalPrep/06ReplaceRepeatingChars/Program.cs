using System;
using System.Text;

namespace _06ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();

            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length - 1; i++)
            {
               if(input[i] != input[i + 1])
                {
                    sb.Append(input[i]);
                }
            }
            sb.Append(input[input.Length - 1]);
            Console.WriteLine(sb);
            
        }
    }
}
