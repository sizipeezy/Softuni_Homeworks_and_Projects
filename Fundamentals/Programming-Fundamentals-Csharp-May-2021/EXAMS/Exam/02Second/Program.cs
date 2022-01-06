using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Second
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> weapon = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> result = new List<string>();

            string input = Console.ReadLine();


            while (input != "Done")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];

                if (command == "Add")
                {
                    string item = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);

                    if (IsValid(index, weapon))
                    {
                        weapon.Insert(index, item);
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (IsValid(index, weapon))
                    {
                        weapon.RemoveAt(index);
                    }
                }
                else if (command == "Check")
                {
                    string second = cmdArgs[1];

                    if (second == "Even")
                    {
                        for (int i = 0; i < weapon.Count; i++)
                        {

                            if (i % 2 == 0)
                            {
                                //Console.Write(weapon[i] + " ");
                                result.Add(weapon[i]);
                            }

                        }
                    }
                    else if (second == "Odd")
                    {
                        for (int i = 0; i < weapon.Count; i++)
                        {

                            if (i % 2 != 0)
                            {
                                //Console.Write(weapon[i] + " ");
                                result.Add(weapon[i]);
                            }

                        }
                    }
                }



                input = Console.ReadLine();
            }

            Console.Write(string.Join(" ", result));
            Console.WriteLine();
            Console.Write($"You crafted {string.Join("", weapon)}!");


        }

        private static bool IsValid(int index, List<string> weapon)
        {
            return index < weapon.Count && index >= 0;
        }
    }
}
