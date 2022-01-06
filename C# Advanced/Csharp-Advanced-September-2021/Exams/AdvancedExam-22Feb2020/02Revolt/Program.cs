using System;

namespace _02Revolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];
            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                matrix[row] = input;
                for (int col = 0; col < input.Length; col++)
                {

                    if (matrix[row][col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }


            matrix[playerRow][playerCol] = '-';


            bool isEnd = false;
            for (int i = 0; i < count; i++)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    playerRow--;
                    if (IsValid(matrix, playerRow, playerCol))
                    {

                        if (matrix[playerRow][playerCol] != 'T')
                        {
                            if (matrix[playerRow][playerCol] == 'B')
                            {
                                matrix[playerRow][playerCol] = '-';
                                playerRow--;
                                matrix[playerRow][playerCol] = 'f';
                            }
                            else if (matrix[playerRow][playerCol] == 'F')
                            {
                                matrix[playerRow][playerCol] = 'f';
                                Console.WriteLine($"Player won!");
                                isEnd = true;
                                break;
                            }
                        }
                        else
                        {
                            matrix[playerRow][playerCol] = '-';
                            playerRow++;
                            matrix[playerRow][playerCol] = 'f';
                        }

                        matrix[playerRow][playerCol] = 'f';

                    }

                }
                else if (command == "down")
                {
                    playerRow++;
                    if (IsValid(matrix, playerRow, playerCol))
                    {

                        if (matrix[playerRow][playerCol] != 'T')
                        {
                            if (matrix[playerRow][playerCol] == 'B')
                            {
                                matrix[playerRow][playerCol] = '-';
                                playerRow++;
                                matrix[playerRow][playerCol] = 'f';
                            }
                            else if (matrix[playerRow][playerCol] == 'F')
                            {
                                matrix[playerRow][playerCol] = 'f';
                                Console.WriteLine($"Player won!");
                                isEnd = true;
                                break;
                            }
                        }
                        else
                        {
                            matrix[playerRow][playerCol] = '-';
                            playerRow--;
                            matrix[playerRow][playerCol] = 'f';
                        }

                        matrix[playerRow][playerCol] = 'f';

                    }

                }
                else if (command == "left")
                {
                    playerCol--;
                    if (IsValid(matrix, playerRow, playerCol))
                    {

                        if (matrix[playerRow][playerCol] != 'T')
                        {
                            if (matrix[playerRow][playerCol] == 'B')
                            {
                                matrix[playerRow][playerCol] = '-';
                                playerCol--;
                                matrix[playerRow][playerCol] = 'f';
                            }
                            else if (matrix[playerRow][playerCol] == 'F')
                            {
                                matrix[playerRow][playerCol] = 'f';
                                Console.WriteLine($"Player won!");
                                isEnd = true;
                                break;
                            }
                        }
                        else
                        {
                            matrix[playerRow][playerCol] = '-';
                            playerCol++;
                            matrix[playerRow][playerCol] = 'f';
                        }

                        matrix[playerRow][playerCol] = 'f';
                    }


                }
                else if (command == "right")
                {
                    playerCol++;
                    if (IsValid(matrix, playerRow, playerCol))
                    {

                        if (matrix[playerRow][playerCol] != 'T')
                        {
                            if (matrix[playerRow][playerCol] == 'B')
                            {
                                matrix[playerRow][playerCol] = '-';
                                playerCol++;
                                matrix[playerRow][playerCol] = 'f';
                            }
                            else if (matrix[playerRow][playerCol] == 'F')
                            {
                                matrix[playerRow][playerCol] = 'f';
                                Console.WriteLine($"Player won!");
                                isEnd = true;
                                break;
                            }
                        }
                        else
                        {
                            matrix[playerRow][playerCol] = '-';
                            playerCol--;
                            matrix[playerRow][playerCol] = 'f';
                        }

                        matrix[playerRow][playerCol] = 'f';

                    }

                }

                if (isEnd)
                {
                    printMatrix(matrix);
                    return;
                }

            }

            Console.WriteLine($"Player lost!");

            printMatrix(matrix);
        }

        private static bool IsValid(char[][] matrix, int playerRow, int playerCol)
        {
            if (playerRow >= 0 && playerRow < matrix.GetLength(0)
                && playerCol >= 0 && playerCol < matrix[playerRow].Length)
            {
                return true;
            }
            return false;
        }

        private static void printMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
