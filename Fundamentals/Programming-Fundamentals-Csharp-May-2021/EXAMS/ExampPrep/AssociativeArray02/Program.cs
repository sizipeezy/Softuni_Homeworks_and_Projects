using System;
using System.Collections.Generic;

namespace AssociativeArray02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            var output = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (output.ContainsKey(word.ToLower()))
                {
                    output[word.ToLower()]++;
                }
                else
                {
                    output.Add(word.ToLower(), 1);
                }
            }

            foreach (var item in output)
            {
                if(item.Value % 2 == 0)
                {
                    Console.Write(item.Key + " ");
                }
            }

        }
    }
}
