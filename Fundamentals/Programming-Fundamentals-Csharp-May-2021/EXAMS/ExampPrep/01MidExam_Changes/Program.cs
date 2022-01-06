using System;
using System.Collections.Generic;
using System.Linq;

namespace _01MidExam_Changes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .ToList();
            int numberOfMoves = 0;
            string input = Console.ReadLine();
            while (input != "end")
            {
                numberOfMoves++;

                string[] cmdArgs = input.Split(" ");
                int index1 = int.Parse(cmdArgs[0]);
                int index2 = int.Parse(cmdArgs[1]);

                if (index1 >= 0 && index2 >= 0 && index1 < nums.Count && index2 < nums.Count && index1 != index2)
                {
                    if (nums[index1] == nums[index2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {nums[index1]}!");

                        if (index1 > index2)
                        {
                            nums.RemoveAt(index1);
                            nums.RemoveAt(index2);
                        }
                        else
                        {
                            nums.RemoveAt(index2);
                            nums.RemoveAt(index1);
                        }

                        if (nums.Count == 0)
                        {
                            Console.WriteLine($"You have won in {numberOfMoves} turns!");
                            return;
                        }
                    }
                    else if (nums[index1] != nums[index2])
                    {
                        Console.WriteLine("Try again!");
                    }


                }
                else
                {
                    nums.Insert(nums.Count / 2, $"-{numberOfMoves}a");
                    nums.Insert(nums.Count / 2, $"-{numberOfMoves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }



                //Console.WriteLine(String.Join(" ", input));
                input = Console.ReadLine();
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
