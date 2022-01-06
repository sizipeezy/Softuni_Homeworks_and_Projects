using System;
using System.Collections.Generic;
using System.Linq;

namespace _02MidExam_ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                                        .Split("!", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                string item = cmdArgs[1];

                if(command == "Urgent")
                {
                    if(!items.Contains(item))
                    {
                        items.Insert(0, item);
                    }
                }
                else if(command == "Unnecessary")
                {
                    if(items.Contains(item))
                    {
                        items.RemoveAll(w => w == item);
                    }
                }
                else if(command == "Correct")
                {
                    string oldItem = item;
                    string newItem = cmdArgs[2];

                    if(items.Contains(item))
                    {
                        int index = items.FindIndex(x => x == oldItem);
                        items.RemoveAt(index);
                        items.Insert(index, newItem);
                    }

                }
                else if(command == "Rearrange")
                {
                    if(items.Contains(item))
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
