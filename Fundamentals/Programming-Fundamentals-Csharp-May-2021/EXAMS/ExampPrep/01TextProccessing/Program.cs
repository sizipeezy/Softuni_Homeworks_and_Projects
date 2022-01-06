using System;
using System.Linq;

namespace _01TextProccessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            while (input != "end")
            {
                result = new string(input.Reverse().ToArray());

                Console.WriteLine($"{input} = {string.Join("", result)}");
                input = Console.ReadLine();
           


            }
        }
    }
}
