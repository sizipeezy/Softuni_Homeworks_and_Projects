using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamRetake3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();

            string input = string.Empty;

            while ((input= Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                if(command == "Change")
                {
                    int n1 = int.Parse(cmdArgs[1]);
                    int n2 = int.Parse(cmdArgs[2]);

                    if(nums.Contains(n1))
                    {
                        int index = nums.IndexOf(n1);
                        nums[index] = n2;
                    }

                    
                }
                else if(command == "Hide")
                {
                    int n1 = int.Parse(cmdArgs[1]);
                    if(nums.Contains(n1))
                    {
                        nums.Find(x => x == n1);
                        nums.Remove(n1);

                    }
                  

                }
                else if(command == "Switch")
                {
                    int n1 = int.Parse(cmdArgs[1]);
                    int n2 = int.Parse(cmdArgs[2]);


                    
                    if(nums.Contains(n1) && nums.Contains(n2))
                    {
                        int index1 = nums.IndexOf(n1);
                        int index2 = nums.IndexOf(n2);

                        nums[index1] = n2;
                        nums[index2] = n1;
                      
                    }
                }
                else if(command == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]) + 1;

                    int value = int.Parse(cmdArgs[2]);

                    if(index > 0 &&  index < nums.Count)
                    {
                        nums.Insert(index, value);
                    }
                    

                }
                else if(command == "Reverse")
                {
                    nums.Reverse();
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
