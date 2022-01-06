using System;

namespace _02Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];
            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Replace(" ", "").ToCharArray();
                matrix[row] = input;
                for (int col = 0; col < input.Length; col++)
                {
                    playerRow = row;
                    playerCol = col;
                }

            }
            int playerTokens = 0;
            int enemyTokens = 0;

            string command = Console.ReadLine();

            while (command != "Gong")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs.Length == 3)
                {
                    int row = int.Parse(cmdArgs[1]);
                    int col = int.Parse(cmdArgs[2]);
                    if (IsValid(row, col, matrix))
                    {
                        if(matrix[row][col] == 'T')
                        {
                            playerTokens++;
                            matrix[row][col] = '-';
                        }

                    }
                }
                else
                {
                    int enemyRow = int.Parse(cmdArgs[1]);
                    int enemyCol = int.Parse(cmdArgs[2]);
                    string direction = cmdArgs[3];

                    if (IsValid(enemyRow, enemyCol, matrix))
                    {
                        if (matrix[enemyRow][enemyCol] == 'T')
                        {
                            enemyTokens++;
                            matrix[enemyRow][enemyCol] = '-';
                        }

                        if (direction == "up")
                        {
                            for (int i = 1; i <= 3; i++)
                            {
                                int movement = enemyRow - i;
                                if(IsValid(movement, enemyCol, matrix))
                                {
                                    if(matrix[movement][enemyCol] == 'T')
                                    {
                                        enemyTokens++;
                                        matrix[movement][enemyCol] = '-';
                                    }
                                    else if(matrix[movement][enemyCol] != 'T')
                                    {
                                        continue;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else if (direction == "down")
                        {
                            for (int i = 1; i <= 3; i++)
                            {
                                int movement = enemyRow + i;
                                if (IsValid(movement, enemyCol, matrix))
                                {
                                    if (matrix[movement][enemyCol] == 'T')
                                    {
                                        enemyTokens++;
                                        matrix[movement][enemyCol] = '-';
                                    }
                                    else if (matrix[movement][enemyCol] != 'T')
                                    {
                                        continue;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else if (direction == "left")
                        {
                            for (int i = 1; i <= 3; i++)
                            {
                                int movement = enemyCol - i;
                                if (IsValid(enemyRow, movement, matrix))
                                {
                                    if (matrix[enemyRow][movement] == 'T')
                                    {
                                        enemyTokens++;
                                        matrix[enemyRow][movement] = '-';
                                    }
                                    else if (matrix[enemyRow][movement] != 'T')
                                    {
                                        continue;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else if (direction == "right")
                        {
                            for (int i = 1; i <= 3; i++)
                            {
                                int movement = enemyCol + i;
                                if (IsValid(enemyRow, movement, matrix))
                                {
                                    if (matrix[enemyRow][movement] == 'T')
                                    {
                                        enemyTokens++;
                                        matrix[enemyRow][movement] = '-';
                                    }
                                    else if (matrix[enemyRow][movement] != 'T')
                                    {
                                        continue;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }



                command = Console.ReadLine();
            }

            printMatrix(matrix);
            Console.WriteLine($"Collected tokens: {playerTokens}");
            Console.WriteLine($"Opponent's tokens: {enemyTokens}");
        }

        private static bool IsValid(int row, int col, char[][] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix[row].Length)
            {
                return true;
            }
            return false;
        }

        private static void printMatrix(char[][] matrix)
        {
            foreach (var line in matrix)
            {
                var currentLine = string.Join(' ', line);
                Console.WriteLine(currentLine);
            }
        }
    }
}
