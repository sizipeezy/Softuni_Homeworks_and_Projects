using System;
using System.Text;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var sb = new StringBuilder(32);

            for (int i = 0; i < text.Length; i++)
            {
                sb.Append(text[i]);
            }

            sb.Insert(5, "hey gey");
            Console.WriteLine(sb);
        }
    }
}
