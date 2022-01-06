using System;

namespace _02SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                return;
            }

            char[][] matrix = new char[n][];
            int marioRow = 0;
            int marioCol = 0;

            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();
                char[] arr = line.ToCharArray();
                matrix[row] = arr;
                for (int col = 0; col < line.Length; col++)
                {
                    if (matrix[row][col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                }

            }

            //bool isDead = false;
            while (true)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                int enemyRow = int.Parse(cmdArgs[1]);
                int enemyCol = int.Parse(cmdArgs[2]);


                lives--;
                matrix[enemyRow][enemyCol] = 'B';
                matrix[marioRow][marioCol] = '-';


                if (action == "W")
                {
                    if (isValid(marioRow - 1, marioCol, matrix))
                    {
                       
                        if (matrix[marioRow - 1][marioCol] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                Console.WriteLine($"Mario died at {marioRow - 1};{marioCol}.");
                                matrix[marioRow - 1][marioCol] = 'X';
                                
                                break;

                            }
                           
                        }

                        if (matrix[marioRow - 1][marioCol] == 'P')
                        {
                            matrix[marioRow - 1][marioCol] = '-';
                            matrix[marioRow][marioCol] = '-';
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                            break;
                        }
                        else
                        {
                            matrix[marioRow - 1][marioCol] = 'M';
                            matrix[marioRow][marioCol] = '-';
                            marioRow--;
                        }
                    }
                    else
                    {
                        lives--;
                    }

                    
                }
                else if (action == "S")
                {

                    if (isValid(marioRow + 1, marioCol, matrix))
                    {

                        if (matrix[marioRow + 1][marioCol] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                Console.WriteLine($"Mario died at {marioRow + 1};{marioCol}.");
                                matrix[marioRow + 1][marioCol] = 'X';
                                
                                break;

                            }
                            
                        }


                        if (matrix[marioRow + 1][marioCol] == 'P')
                        {
                            matrix[marioRow + 1][marioCol] = '-';
                            matrix[marioRow][marioCol] = '-';
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                            break;
                        }
                        else
                        {
                            matrix[marioRow + 1][marioCol] = 'M';
                            matrix[marioRow][marioCol] = '-';
                            marioRow--;
                        }

                    }
                    else
                    {
                        lives--;
                    }
                    
                }
                else if (action == "A")
                {
                    if (isValid(marioRow, marioCol - 1, matrix))
                    {
                       

                        if (matrix[marioRow][marioCol - 1] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                Console.WriteLine($"Mario died at {marioRow};{marioCol - 1}.");
                                matrix[marioRow][marioCol - 1] = 'X';
                                
                                break;

                            }
                           
                        }

                        if (matrix[marioRow][marioCol - 1] == 'P')
                        {
                            matrix[marioRow][marioCol - 1] = '-';
                            matrix[marioRow][marioCol] = '-';
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                            break;
                        }
                        else
                        {
                            matrix[marioRow][marioCol - 1] = 'M';
                            matrix[marioRow][marioCol] = '-';
                            marioRow--;
                        }
                    }
                    else
                    {
                        lives--;
                    }
               
                }
                else if (action == "D")
                {
                    if (isValid(marioRow, marioCol + 1, matrix))
                    {
                        

                        if (matrix[marioRow][marioCol + 1] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                Console.WriteLine($"Mario died at {marioRow};{marioCol + 1}.");
                                matrix[marioRow][marioCol + 1] = 'X';
                                
                                break;

                            }
                           
                        }

                        if (matrix[marioRow][marioCol + 1] == 'P')
                        {
                            
                            matrix[marioRow][marioCol + 1] = '-';
                            matrix[marioRow][marioCol] = '-';
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                            break;
                        }

                        else
                        {
                            matrix[marioRow][marioCol - 1] = 'M';
                            matrix[marioRow][marioCol] = '-';
                            marioRow--;
                        }
                    }
                    else
                    {
                        lives--;
                    }
                  
                }


            }

            PrintMatrix(matrix);

        }

        private static bool isValid(int marioRow, int marioCol, char[][] matrix)
        {
            return marioRow >= 0 && marioRow < matrix.GetLength(0)
                && marioCol >= 0 && marioCol < matrix[marioRow].Length;
        }

        private static void PrintMatrix(char[][] matrix)
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
