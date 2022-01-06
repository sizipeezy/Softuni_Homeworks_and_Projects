using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MidExam_MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArgs = input.Split().ToArray();
                string command = cmdArgs[0];
                int index = int.Parse(cmdArgs[1]);

                if (command == "Shoot")
                {
                    int power = int.Parse(cmdArgs[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add")
                {
                    int value = int.Parse(cmdArgs[2]);

                    if (index >= 0 && index < input.Length)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command == "Strike")
                {
                    int radius = int.Parse(cmdArgs[2]);

                    if (index - radius >= 0 && index + radius < targets[targets.Count - 1])
                    {
                        targets.RemoveRange(index - radius, radius * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
