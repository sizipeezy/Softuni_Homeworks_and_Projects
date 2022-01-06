using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasksValues = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var threadsValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            Stack<int> tasks = new Stack<int>(tasksValues);
            Queue<int> threads = new Queue<int>(threadsValues);

            int killValue = int.Parse(Console.ReadLine());

            while (tasks.Peek() != (killValue))
            {
                int currentTask = tasks.Peek();
                int currentThread = threads.Peek();

                if(currentThread >= currentTask)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else
                {
                    threads.Dequeue();
                    continue;
                }
            }

            Console.WriteLine($"Thread with value {threads.Peek()} killed task { killValue}");
            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
