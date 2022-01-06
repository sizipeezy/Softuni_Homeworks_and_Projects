using System;
using System.Collections.Generic;
using System.Linq;

namespace _04ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArgs = input.Split(" ");
                string command = cmdArgs[0];

                if (command == "Add")
                {
                    int item = int.Parse(cmdArgs[1]);
                    nums.Add(item);
                }
                else if (command == "Insert")
                {
                    int item = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    if (isValid(index, nums.Count))
                    {
                        Console.WriteLine($"Invalid index");
                    }
                    else
                    {
                        nums.Insert(index, item);
                    }

                }
                else if (command == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (isValid(index, nums.Count))
                    {
                        Console.WriteLine($"Invalid index");
                    }
                    else
                    {
                        nums.RemoveAt(index);
                    }
                }
                else if (command == "Shift")
                {
                    int rotation = int.Parse(cmdArgs[2]);
                    if (cmdArgs[1] == "left")
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int firstElement = nums[0];
                            for (int j = 0; j < nums.Count - 1; j++)
                            {
                                nums[j] = nums[j + 1];
                            }

                            nums[nums.Count - 1] = firstElement;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int LastElement = nums[nums.Count - 1];
                            for (int j = nums.Count - 1; j > 0; j--)
                            {
                                nums[j] = nums[j - 1];
                            }

                            nums[0] = LastElement;
                        }
                    }


                }
                input = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ", nums));
        }

        private static bool isValid(int index, int count)
        {
            return index > count || index < 0;
        }
    }
    
}
