using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamRetake2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> result = new List<int>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];

                if (command == "add")
                {
                    if (cmdArgs[2] == "start")
                    {

                        var getNumbers = (from x in cmdArgs
                                          where char.IsDigit(x)
                                          select x).ToArray();
                        foreach (var item in nms)
                        {
                            int curr = item;
                            nums.Insert(0, item);
                        }
                    }
                    else if (cmdArgs[2] == "end")
                    {
                        int[] nms = cmdArgs[3].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                        foreach (var item in nms)
                        {
                            int curr = item;
                            nums.Add(item);
                        }
                    }

                }

                else if (command == "remove")
                {
                    if (cmdArgs[1] == "lower")
                    {
                        int value = int.Parse(cmdArgs[3]);
                       
                            nums.RemoveAll(x => x < value);
                         
                        
                    }
                    else if (cmdArgs[1] == "greater")
                    {
                        int value = int.Parse(cmdArgs[3]);
                        nums.RemoveAll(x => x > value);
                    }
                    else if (cmdArgs[1] == "at")
                    {
                        int n1 = int.Parse(cmdArgs[3]);
                        int index = n1;

                        if (index >= 0 && index <= nums.Count)
                        {
                            nums.RemoveAt(index);

                        }
                    }
                    else if (cmdArgs[1] == "count")
                    {
                        int count = int.Parse(cmdArgs[2]);

                        nums.RemoveRange(nums.Count - count, count);
                    }

                }

                else if (command == "replace")
                {
                    int value = int.Parse(cmdArgs[1]);
                    int replace = int.Parse(cmdArgs[2]);

                    if (nums.Contains(value))
                    {
                        int index = nums.IndexOf(value);
                        nums[index] = replace;
                    }
                }
                else if (command == "find")
                {
                    if (cmdArgs[1] == "even")
                    {
                        Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 == 0)));
                    }
                    else if (cmdArgs[1] == "odd")
                    {
                        Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 != 0)));
                    }
                }

            }
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}

