using System;
using System.Collections.Generic;
using System.Linq;

namespace _07ListAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                if (command == "Add")
                {
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Add(number);
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Remove(number);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(cmdArgs[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    numbers.Insert(index, number);
                }

                else if (command == "Contains")
                {
                    int number = int.Parse(cmdArgs[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(w => w % 2 == 0).ToList()));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(w => w % 2 != 0).ToList()));
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(string.Join(" ", numbers.Sum()));
                }
                else if (command == "Filter")
                {
                    string result = string.Empty;


                    if (cmdArgs[1] == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n < int.Parse(cmdArgs[2]))));

                    }
                    else if (cmdArgs[1] == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n > int.Parse(cmdArgs[2]))));
                    }

                    else if (cmdArgs[1] == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n <= int.Parse(cmdArgs[2]))));
                    }

                    else if (cmdArgs[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n >= int.Parse(cmdArgs[2]))));
                    }


                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
