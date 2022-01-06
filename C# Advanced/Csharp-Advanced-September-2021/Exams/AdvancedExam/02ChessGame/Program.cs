using System;

namespace _02ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            char[,] matrix = new char[n, n];


            int whiteRow = -1;
            int whiteCol = -1;

            int blackRow = -1;
            int blackCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputLine = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputLine[col];
                    if (matrix[row, col] == 'w')
                    {
                        whiteRow = row;
                        whiteCol = col;
                    }
                    else if (matrix[row, col] == 'b')
                    {
                        blackRow = row;
                        blackCol = col;
                    }
                }
            }

            for (int i = 0; i <= n; i++)
            {
               
                if(isValid(matrix, whiteRow, whiteCol))
                {
                    matrix[whiteRow, whiteCol] = '-';
                    matrix[whiteRow + 1, whiteCol] = 'w';
                    if((blackRow == whiteRow - 1) && 
                        (blackCol == whiteCol - 1) || (blackCol == whiteCol - 1))
                    {
                        Console.WriteLine($"Game over! white capture on {whiteRow}{whiteCol}.");
                        break;
                    }
                    else
                    {
                        whiteRow++;
                    }
                }

                if(isValid(matrix, blackRow, blackCol))
                {
                    matrix[blackRow, blackCol] = '-';
                    matrix[blackRow - 1, blackCol] = 'b';
                    if ((whiteRow == blackRow - 1) &&
                       (whiteCol == blackCol + 1) || (whiteCol == blackCol + 1))
                    {
                        Console.WriteLine($"Game over! black capture on {blackRow}{blackCol}");
                        break;
                    }
                    else
                    {
                        blackRow--;
                    }
                }
            }


        }

        private static bool isValid(char[,] matrix, int whiteRow, int whiteCol)
        {
            if(whiteRow >=0 && whiteRow < matrix.GetLength(0)
                && whiteCol >= 0 && whiteCol < matrix.GetLength(1))
            {
                return true;

            }
            return false;
        }
    }
}
