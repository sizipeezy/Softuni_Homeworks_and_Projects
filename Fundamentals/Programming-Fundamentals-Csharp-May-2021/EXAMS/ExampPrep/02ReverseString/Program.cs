using System;
using System.Text;

namespace _02ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            var result = new StringBuilder();

            foreach (var item in words)
            {
                int count = item.Length;

                for (int i = 0; i < count; i++)
                {
                    result.Append(item);
                }
            }

            Console.WriteLine(result);
        }
    }
}
