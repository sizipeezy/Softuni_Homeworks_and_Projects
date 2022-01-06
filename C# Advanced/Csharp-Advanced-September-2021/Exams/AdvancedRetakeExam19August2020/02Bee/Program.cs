using System;

namespace _02Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int beeRow = -1;
            int beeCol = -1;

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if(matrix[row,col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }

            int flowersCount = 0;

            string command = Console.ReadLine();
            while (command != "End")
            {
                matrix[beeRow, beeCol] = '.';
                beeRow = MoveRow(beeRow,command);
                beeCol = MoveCol(beeCol, command);


                if(!IsValid(matrix, beeRow, beeCol))
                {
                    Console.WriteLine($"The bee got lost!");
                    break;
                }
               

                if(matrix[beeRow, beeCol] == 'f')
                {
                    flowersCount++;
                }

                if(matrix[beeRow, beeCol] == 'O')
                {
                    matrix[beeRow, beeCol] = '.';
                    beeRow = MoveRow(beeRow, command);
                    beeCol = MoveCol(beeCol, command);

                    if (!IsValid(matrix, beeRow, beeCol))
                    {
                        Console.WriteLine($"The bee got lost!");
                        break;
                    }


                    if (matrix[beeRow, beeCol] == 'f')
                    {
                        flowersCount++;
                    }
                }


                matrix[beeRow, beeCol] = 'B';

                command = Console.ReadLine();
                
            }
            if (flowersCount < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flowersCount} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowersCount} flowers!");
            }


            printMatrix(matrix);
        }

        private static bool IsValid(char[,] matrix, int beeRow, int beeCol)
        {
            if(beeRow >= 0 && beeRow < matrix.GetLength(0)
                && beeCol >= 0 && beeCol < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

        private static int MoveCol(int beeCol, string command)
        {
            if(command == "left")
            {
                return beeCol -= 1;
            }

            if(command == "right")
            {
                return beeCol += 1;
            }

            return beeCol;
        }

        private static int MoveRow(int beeRow, string command)
        {
            if(command == "up")
            {
                return beeRow -= 1;
            }

            if(command == "down")
            {
                return beeRow += 1;
            }

            return beeRow;
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
