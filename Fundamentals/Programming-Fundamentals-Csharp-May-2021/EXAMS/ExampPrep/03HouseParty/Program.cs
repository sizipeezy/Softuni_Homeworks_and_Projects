using System;
using System.Collections.Generic;

namespace _03HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                if(cmdArgs.Length > 3)
                {
                    if(names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if(names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);
                    }


                }

            }
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
