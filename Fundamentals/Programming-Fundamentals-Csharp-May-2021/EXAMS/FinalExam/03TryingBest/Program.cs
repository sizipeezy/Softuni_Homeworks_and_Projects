using System;
using System.Collections.Generic;
using System.Linq;

namespace _03TryingBest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            string[] cmdArgs = command.Split(" | ");
            for (int i = 0; i < cmdArgs.Length; i++)
            {
                string[] result = cmdArgs[i].Split(": ");
                string word = result[0];
                string deff = result[1];
                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }
                words[result[0]].Add(deff);

            }


            string[] wordsToTest = Console.ReadLine().Split(" | ");


            string input = Console.ReadLine();
            if(input == "Test")
            {
                for (int i = 0; i < wordsToTest.Length; i++)
                {
                    string currentWord = wordsToTest[i];
                    if (words.ContainsKey(currentWord))
                    {
                        foreach (var word in words.OrderBy(x => x.Key).Where(x => x.Key == currentWord))
                        {
                            Console.WriteLine($"{word.Key}:");
                            foreach (var item in word.Value.OrderByDescending(x => x.Length))
                            {
                                Console.WriteLine($" -{item}");
                            }
                        }
                    }

                }
            }
            else if(input == "Hand Over")
            {
                string[] result = words.OrderBy(x => x.Key)
                    .Select(x => x.Key.ToString()).ToArray();

                Console.WriteLine(string.Join(" ", result));

            }
            
        }
    }
}
