using System;

namespace _02Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            char[][] matrix = new char[n][];
            int playerRow = 0;
            int playerCol = 0;

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

            int enemyTokens  =0;
            int playerTokens = 0;


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
                        if (matrix[row][col] == 'T')
                        {
                            playerTokens++;
                            matrix[row][col] = '-';
                        }

                    }
                }
                else if (cmdArgs.Length == 4)
                {
                    int opponentRow = int.Parse(cmdArgs[1]);
                    int opponentCol = int.Parse(cmdArgs[2]);
                    string direction = cmdArgs[3];
                    if (IsValid(opponentRow, opponentCol, matrix))
                    {
                        if (matrix[opponentRow][opponentCol] == 'T')
                        {
                            enemyTokens++;
                            matrix[opponentRow][opponentCol] = '-';
                        }

                        switch (direction)
                        {
                            case "up":

                                for (int i = 1; i <=3 ; i++)
                                {

                                    int movement = opponentRow - i;
                                    if (IsValid(movement, opponentCol, matrix))
                                    {
                                        if (matrix[movement][opponentCol] == 'T')
                                        {
                                            enemyTokens++;
                                            matrix[movement][opponentCol] = '-';
                                        }
                                        else if (matrix[movement][opponentCol] != 'T')
                                        {
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            case "down":
                                for (int i = 1; i <= 3; i++)
                                {

                                    int movement = opponentRow + i;
                                    if (IsValid(movement, opponentCol, matrix))
                                    {
                                        if (matrix[movement][opponentCol] == 'T')
                                        {
                                            enemyTokens++;
                                            matrix[movement][opponentCol] = '-';
                                        }
                                        else if (matrix[movement][opponentCol] != 'T')
                                        {
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            case "left":
                                for (int i = 1; i <= 3; i++)
                                {

                                    int movement = opponentCol - i;
                                    if (IsValid(opponentRow, movement, matrix))
                                    {
                                        if (matrix[opponentRow][movement] == 'T')
                                        {
                                            enemyTokens++;
                                            matrix[opponentRow][movement] = '-';
                                        }
                                        else if (matrix[opponentRow][movement] != 'T')
                                        {
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            case "right":
                                for (int i = 1; i <= 3; i++)
                                {

                                    int movement = opponentCol  + i;
                                    if (IsValid(opponentRow, movement, matrix))
                                    {
                                        if (matrix[opponentRow][movement] == 'T')
                                        {
                                            enemyTokens++;
                                            matrix[opponentRow][movement] = '-';
                                        }
                                        else if (matrix[opponentRow][movement] != 'T')
                                        {
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }



                command = Console.ReadLine();

            }
            printMatrix(matrix);
            Console.WriteLine($"Collected tokens: {playerTokens}");
            Console.WriteLine($"Opponent's tokens: {enemyTokens}");
        }

        private static void printMatrix(char[][] matrix)
        {
            foreach (var line in matrix)
            {
                var currentLine = string.Join(' ', line);
                Console.WriteLine(currentLine);
            }
        }

        private static bool IsValid(int row, int col, char[][] matrix)
        {
            if(row >= 0 && row < matrix.GetLength(0) 
                && col >= 0 && col < matrix[row].Length)
            {
                return true;
            }
            return false;
        }
    }
}
