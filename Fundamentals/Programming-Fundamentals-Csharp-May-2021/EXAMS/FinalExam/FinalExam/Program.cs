using System;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                if(command == "Translate")
                {
                    char ch = char.Parse(cmdArgs[1]);
                    char replace = char.Parse(cmdArgs[2]);

                    if(word.Contains(ch) && ch != replace)
                    {
                        word = word.Replace(ch, replace);
                    }

                    Console.WriteLine(word);
                }
                else if(command == "Includes")
                {
                    string something = cmdArgs[1];
                    if(word.Contains(something))
                    {
                        Console.WriteLine($"True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if(command == "Start")
                {
                    string something = cmdArgs[1];

                    if(word.StartsWith(something))
                    {
                        Console.WriteLine($"True");
                    }
                    else
                    {
                        Console.WriteLine($"False");
                    }

                }
                else if(command == "Lowercase")
                {
                    word = word.ToLower();
                    Console.WriteLine(word);
                }
                else if(command == "FindIndex")
                {
                    char ch = char.Parse(cmdArgs[1]);

                    int index = word.LastIndexOf(ch);

                    Console.WriteLine(index);
                }
                else if(command == "Remove")
                {
                    int startIndex = int.Parse(cmdArgs[1]);

                    int count = int.Parse(cmdArgs[2]);

                    word = word.Remove(startIndex, count);

                    Console.WriteLine(word);
                }
            }
        }
    }
}
