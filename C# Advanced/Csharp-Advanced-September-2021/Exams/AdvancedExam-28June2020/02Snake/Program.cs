using System;

namespace _02Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int snakeRow = -1;
            int snakeCol = -1;

            int firstBurrowRow = -1;
            int firstBurrowCol = -1;

            int secondBurrowRow = -1;
            int secondBurrowCol = -1;


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if(matrix[row,col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                    if (matrix[row, col] == 'B')
                    {
                        if (firstBurrowRow == -1)
                        {
                            firstBurrowRow = row;
                            firstBurrowCol = col;
                        }
                        else
                        {
                            secondBurrowRow = row;
                            secondBurrowCol = col;
                        }
                    }

                }
            }

            int foodEaten = 0;
            matrix[snakeRow, snakeCol] = '.';
            
            while (true)
            {
                string command = Console.ReadLine();
                if (foodEaten >= 10)
                {
                    Console.WriteLine($"You won! You fed the snake.");

                    matrix[snakeRow, snakeCol] = 'S';
                    break;
                }

                if (command == "up")
                {
                    snakeRow--;
                    if(IsValid(matrix, snakeRow, snakeCol))
                    {
                        if(matrix[snakeRow,snakeCol] == '*')
                        {
                            foodEaten++;
                            matrix[snakeRow, snakeCol] = '.';

                        }
                        if(matrix[snakeRow, snakeCol] == 'B')
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            if (firstBurrowRow == snakeRow && firstBurrowCol == snakeCol)
                            {
                                snakeRow = secondBurrowRow;
                                snakeCol = secondBurrowCol;
                            }
                            else
                            {
                                snakeRow = firstBurrowRow;
                                snakeCol = firstBurrowCol;
                            }
                        }
                        else if(matrix[snakeRow , snakeCol] == '-')
                        {
                            matrix[snakeRow, snakeCol] = '.';
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Game over!");
                        break;
                    }
                }
                else if(command == "down")
                {
                    snakeRow++;
                    if (IsValid(matrix, snakeRow, snakeCol))
                    {
                        if (matrix[snakeRow, snakeCol] == '*')
                        {
                            foodEaten++;
                            matrix[snakeRow, snakeCol] = '.';

                        }
                        if (matrix[snakeRow, snakeCol] == 'B')
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            if (firstBurrowRow == snakeRow && firstBurrowCol == snakeCol)
                            {
                                snakeRow = secondBurrowRow;
                                snakeCol = secondBurrowCol;
                            }
                            else
                            {
                                snakeRow = firstBurrowRow;
                                snakeCol = firstBurrowCol;
                            }
                        }
                        else if (matrix[snakeRow, snakeCol] == '-')
                        {
                            matrix[snakeRow, snakeCol] = '.';
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Game over!");
                        break;
                    }
                }
                else if(command == "left")
                {
                    snakeCol--;
                    if (IsValid(matrix, snakeRow, snakeCol))
                    {
                        if (matrix[snakeRow, snakeCol] == '*')
                        {
                            foodEaten++;
                            matrix[snakeRow, snakeCol] = '.';

                        }
                        if (matrix[snakeRow, snakeCol] == 'B')
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            if (firstBurrowRow == snakeRow && firstBurrowCol == snakeCol)
                            {
                                snakeRow = secondBurrowRow;
                                snakeCol = secondBurrowCol;
                            }
                            else
                            {
                                snakeRow = firstBurrowRow;
                                snakeCol = firstBurrowCol;
                            }
                        }
                        else if (matrix[snakeRow, snakeCol] == '-')
                        {
                            matrix[snakeRow, snakeCol] = '.';
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Game over!");
                        break;
                    }
                }
                else if(command == "right")
                {
                    snakeCol++;
                    if (IsValid(matrix, snakeRow, snakeCol))
                    {
                        if (matrix[snakeRow, snakeCol] == '*')
                        {
                            foodEaten++;
                            matrix[snakeRow, snakeCol] = '.';

                        }
                        if (matrix[snakeRow, snakeCol] == 'B')
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            if (firstBurrowRow == snakeRow && firstBurrowCol == snakeCol)
                            {
                                snakeRow = secondBurrowRow;
                                snakeCol = secondBurrowCol;
                            }
                            else
                            {
                                snakeRow = firstBurrowRow;
                                snakeCol = firstBurrowCol;
                            }
                        }
                        else if (matrix[snakeRow, snakeCol] == '-')
                        {
                            matrix[snakeRow, snakeCol] = '.';
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Game over!");
                        break;
                    }

                }

               
                matrix[snakeRow, snakeCol] = '.';
            }
            Console.WriteLine($"Food eaten: {foodEaten}");
            printMatrix(matrix);
        }

        private static bool IsValid(char[,] matrix, int snakeRow, int snakeCol)
        {
            if(snakeRow >= 0 && snakeRow < matrix.GetLength(0)
                && snakeCol >= 0 && snakeCol < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

        private static void printMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
