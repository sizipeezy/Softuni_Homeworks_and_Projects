using System;
using System.Collections.Generic;

namespace _05Softuni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var output = new Dictionary<string, string>();


            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string name = cmdArgs[1];

                if (command == "register")
                {
                    string licenseNum = cmdArgs[2];

                    if (!output.ContainsKey(name))
                    {
                        output.Add(name, licenseNum);
                        Console.WriteLine($"{name} registered {licenseNum} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseNum}");
                    }

                }
                else if (command == "unregister")
                {
                    if (output.ContainsKey(name))
                    {
                        output.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }



                }
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }

}
