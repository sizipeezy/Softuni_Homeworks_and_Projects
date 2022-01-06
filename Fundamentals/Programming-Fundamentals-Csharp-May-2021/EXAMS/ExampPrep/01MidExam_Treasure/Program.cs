using System;
using System.Collections.Generic;
using System.Linq;

namespace _01MidExam_Treasure
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                                        .Split("|", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();

            string input = Console.ReadLine();

            while (input != "Yohoho!")
            {
                string[] cmdArgs = input.Split(" ");
                string commnad = cmdArgs[0];

                if (commnad == "Loot")
                {
                    if (commnad == "Loot")
                    {
                        for (int i = 1; i < cmdArgs.Length; i++)
                        {
                            if (!items.Contains(cmdArgs[i]))
                            {
                                items.Insert(0, cmdArgs[i]);
                            }
                        }

                    }
                }
                else if (commnad == "Drop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index >= 0 && index < items.Count)
                    {
                        string removedItem = items[index];
                        items.RemoveAt(index);
                        items.Add(removedItem);
                    }
                }
                else if (commnad == "Steal")
                {
                    List<string> steal = new List<string>();
                    int count = int.Parse(cmdArgs[1]);

                    if (count < items.Count)
                    {
                        for (int i = items.Count - count; i < items.Count; i++)
                        {
                            steal.Add(items[i]);
                        }
                        Console.WriteLine(string.Join(", ", steal));
                        items.RemoveRange(items.Count - count, count);
                    }
                    else
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            steal.Add(items[i]);
                        }

                        Console.WriteLine(string.Join(", ", steal));
                        items.RemoveRange(0, items.Count);
                    }
                }


                input = Console.ReadLine();
            }
            double sum = 0;
            double avg = 0;

            foreach (var item in items)
            {
                sum = sum + item.Length;
            }


            if (items.Count != 0)
            {
                avg = sum / items.Count;

                Console.WriteLine($"Average treasure gain: {avg:f2} pirate credits.");
            }

            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }

        }
    }
}
