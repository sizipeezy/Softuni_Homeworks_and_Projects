using System;

namespace _03Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = Console.ReadLine();


            int index = text.IndexOf(input);
            while (index != -1)
            {
                text = text.Remove(index, input.Length);
                index = text.IndexOf(input);
            }

            Console.WriteLine(text);
        }
    }
}
