using System;

namespace _02RevoltSecondTry
{
    class Program
    {

        static char[,] matrix;
        static int playerRow;
        static int playerCol;

        static int checkRowT;
        static int checkColT;

        static bool isTrue;
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size, size];

            int countOfCommands = int.Parse(Console.ReadLine());


            playerRow = 0;
            playerCol = 0;

            checkRowT = 0;
            checkColT = 0;

            isTrue = false;



            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }


            for (int i = 0; i < countOfCommands; i++)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    checkRowT = playerRow;
                    checkColT = playerCol;

                    if (playerRow - 1 < 0)
                    {
                        playerRow = matrix.GetLength(0) - 1;
                    }
                    else
                    {
                        playerRow = playerRow - 1;
                    }


                    if (matrix[playerRow, playerCol] != 'T')
                    {

                        matrix[checkRowT, checkColT] = '-';
                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            if (playerRow - 1 < 0)
                            {
                                playerRow = matrix.GetLength(0) - 1;
                            }
                            else
                            {
                                playerRow = playerRow - 1;
                            }

                        }

                        if (matrix[playerRow, playerCol] == 'F')
                        {
                            matrix[playerRow, playerCol] = 'f';
                            Console.WriteLine("Player won!");
                            isTrue = true;
                        }
                        matrix[playerRow, playerCol] = 'f';
                    }
                    else
                    {
                        playerRow = checkRowT;
                        playerCol = checkColT;
                    }
                }

                else if (command == "down")
                {
                    checkRowT = playerRow;
                    checkColT = playerCol;

                    if (playerRow + 1 > matrix.GetLength(0))
                    {
                        playerRow = 0;
                    }
                    else
                    {
                        playerRow = playerRow + 1;
                    }

                    if (matrix[playerRow, playerCol] != 'T')
                    {
                        matrix[checkRowT, checkColT] = '-';

                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            if (playerRow + 1 > matrix.GetLength(0))
                            {
                                playerRow = 0;
                            }
                            else
                            {
                                playerRow = playerRow + 1;
                            }


                        }

                        if (matrix[playerRow, playerCol] == 'F')
                        {
                            matrix[playerRow, playerCol] = 'f';
                            Console.WriteLine("Player won!");
                            isTrue = true;
                        }
                        matrix[playerRow, playerCol] = 'f';
                    }
                    else
                    {
                        playerRow = checkRowT;
                        playerCol = checkColT;
                    }
                }

                else if (command == "left")
                {
                    checkRowT = playerRow;
                    checkColT = playerCol;

                    if (playerCol - 1 < 0)
                    {
                        playerCol = matrix.GetLength(1) - 1;
                    }
                    else
                    {
                        playerCol = playerCol - 1;
                    }

                    if (matrix[playerRow, playerCol] != 'T')
                    {
                        matrix[checkRowT, checkColT] = '-';
                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            if (playerCol - 1 < 0)
                            {
                                playerCol = matrix.GetLength(1) - 1;
                            }
                            else
                            {
                                playerCol = playerCol - 1;
                            }

                        }

                        if (matrix[playerRow, playerCol] == 'F')
                        {
                            matrix[playerRow, playerCol] = 'f';
                            Console.WriteLine("Player won!");
                            isTrue = true;
                        }
                        matrix[playerRow, playerCol] = 'f';
                    }
                    else
                    {
                        playerRow = checkRowT;
                        playerCol = checkColT;
                    }
                }

                else if (command == "right")
                {
                    checkRowT = playerRow;
                    checkColT = playerCol;

                    if (playerCol + 1 > matrix.GetLength(1) - 1)
                    {
                        playerCol = 0;
                    }
                    else
                    {
                        playerCol = playerCol + 1;
                    }

                    if (matrix[playerRow, playerCol] != 'T')
                    {
                        matrix[checkRowT, checkColT] = '-';
                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            if (playerCol + 1 > matrix.GetLength(1) - 1)
                            {
                                playerCol = 0;
                            }
                            else
                            {
                                playerCol = playerCol + 1;
                            }

                        }


                        if (matrix[playerRow, playerCol] == 'F')
                        {
                            matrix[playerRow, playerCol] = 'f';
                            Console.WriteLine("Player won!");
                            isTrue = true;
                        }
                        matrix[playerRow, playerCol] = 'f';
                    }
                    else
                    {
                        playerRow = checkRowT;
                        playerCol = checkColT;
                    }
                }



                if (isTrue)
                {
                    MatrixPrint();
                    return;
                }

            }

            Console.WriteLine("Player lost!");
            MatrixPrint();
        }

        static void MatrixPrint()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

    }
}
