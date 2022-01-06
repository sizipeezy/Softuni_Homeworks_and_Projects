using System;
using System.Linq;

namespace _02Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = (input[0]);
            int m = (input[1]);

            int[,] matrix = new int[n, m];


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = 0;
                }
            }


            string command = Console.ReadLine();

            while (command != "Bloom Bloom Plow")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int row = int.Parse(cmdArgs[0]);
                int col = int.Parse(cmdArgs[1]);

                if(row < n && col < m)
                {
                    for (int i = 0; i <  n; i++)
                    {
                        matrix[i, col]++;
                    }
                    for (int i = 0; i < m; i++)
                    {
                        if (i != col)
                        {
                            matrix[row, i]++;
                        }

                    }
                }
                else
                {
                    Console.WriteLine($"Invalid coordinates.");
                }


                command = Console.ReadLine();
            }

            PrintMatrix(matrix);

        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
