using System;
using System.Text;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (char.IsUpper(ch))
                {
                    result.Append(ch);
                }
            }
            Console.WriteLine(result);
        }
    }
}
