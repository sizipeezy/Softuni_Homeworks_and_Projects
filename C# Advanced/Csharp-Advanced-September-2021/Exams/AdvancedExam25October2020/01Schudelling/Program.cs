using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Schudelling
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasksNums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            var threadNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int taskToBeKilled = int.Parse(Console.ReadLine());


            Stack<int> tasks = new Stack<int>(tasksNums);
            Queue<int> threads = new Queue<int>(threadNums);

            while (tasks.Peek() != taskToBeKilled)
            {
                int currentThread = threads.Peek();
                int currentTasks = tasks.Peek();

                if(currentThread >= currentTasks)
                {
                    tasks.Pop();
                    threads.Dequeue();

                }
                else if(currentThread < currentTasks)
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine($"Thread with value {threads.Peek()} killed task { taskToBeKilled}\n{string.Join(" ", threads)}");
        }
    }
}
