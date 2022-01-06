using System;
using System.Linq;

namespace Stack
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();

            while (true)
            {
                var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];

                if (command == "END")
                {
                    break;
                }
                else if (command == "Push")
                {
                    stack.Push(tokens.Skip(1).Select(x => x.Split(",").First()).ToArray());
                }
                else if (command == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                }


            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
