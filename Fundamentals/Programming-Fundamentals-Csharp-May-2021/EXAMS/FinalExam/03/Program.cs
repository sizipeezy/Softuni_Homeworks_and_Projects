using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> notebook = new Dictionary<string, List<string>>();

            List<string> wordsNDeff = Console.ReadLine()
                .Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> words = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> abv = new List<string>();

            string command = Console.ReadLine();
           
            for (int i = 0; i < wordsNDeff.Count; i++)
            {
                abv = wordsNDeff[i].Split(": ").ToList();

                if(!notebook.ContainsKey(abv[0]))
                {
                    notebook.Add(abv[0], new List<string>());
                }

                for (int b = 1; b < abv.Count; b++)
                {
                    notebook[abv[0]].Add(abv[b]);
                }

               
            }
            foreach (var item in words)
            {
                if(notebook.ContainsKey(item))
                {
                    Console.WriteLine(item);
                    var li = notebook[item];
                    li = li.OrderBy(x => x.Length).Reverse().ToList();

                    foreach (var wo in li)
                    {
                        Console.WriteLine($" -{wo}");
                    }
                }
            }

            if(command == "Test")
            {
                if(word)
                return;
            }
            else
            {
                var keys = notebook.Keys.OrderBy(x => x).ToList();
                Console.WriteLine(string.Join(" ", keys));
            }
        }
    }
}
