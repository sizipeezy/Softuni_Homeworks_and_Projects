using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] cmdArgs = command.Split();
                string firstCommand = cmdArgs[0];
                string item = (cmdArgs[1]);

                if(firstCommand == "Urgent")
                {
                    
                    
                    if(!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }

                }
                else if(firstCommand == "Unnecessary")
                {
                    if(groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                    
                }
                else if(firstCommand == "Correct")
                {
                    string secondItem = cmdArgs[2];
                    if(groceries.Contains(item))
                    {

                        int index = groceries.FindIndex(x => x == item);
                        groceries.RemoveAt(index);
                        groceries.Insert(index, secondItem);
                    }
                }

                else if(firstCommand == "Rearrange")
                {
                    if(groceries.Contains(item))
                    {
                        groceries.Remove(item);
                        groceries.Add(item);
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
