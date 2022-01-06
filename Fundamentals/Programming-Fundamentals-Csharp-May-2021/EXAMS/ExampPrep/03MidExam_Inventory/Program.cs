using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MidExam_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();
            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] cmdArgs = input.Split(" - ");
                string command = cmdArgs[0];
                string item = cmdArgs[1];

                if (command == "Collect")
                {
                    if (!items.Contains(item))
                    {
                        items.Add(item);
                    }

                }
                else if (command == "Drop")
                {
                    if (items.Contains(item))
                    {
                        items.RemoveAll(w => w == item);
                    }
                }
                else if (command == "Combine Items")
                {
                    string[] itemsToCombine = cmdArgs[1].Split(":");
                    string oldItem = itemsToCombine[0];
                    string newItem = itemsToCombine[1];
                    if (items.Contains(oldItem))
                    {
                        items.Insert((items.IndexOf(oldItem) + 1), newItem);
                    }
                }
                else if (command == "Renew")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);

                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",items));
        }
    }
}
