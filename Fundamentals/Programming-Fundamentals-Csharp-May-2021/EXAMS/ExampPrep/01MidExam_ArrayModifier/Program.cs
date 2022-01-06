using System;
using System.Linq;

namespace _01MidExam_ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int temp = 0;
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];

                if (command == "swap")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);


                    temp = array[index1];
                    array[index1] = array[index2];
                    array[index2] = temp;
                }
                else if (command == "multiply")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);

                    array[index1] *= array[index2];

                }
                else if (command == "decrease")
                {

                    array = Array.ConvertAll(array, x => x - 1);
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
    
}
