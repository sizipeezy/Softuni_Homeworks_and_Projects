using System;

namespace _02BattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];
            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().ToCharArray();
                matrix[row] = input;
                for (int col = 0; col < input.Length; col++)
                {
                    if(matrix[row][col] == 'A')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }


            while (true)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = cmdArgs[0];
                int enemyRow = int.Parse(cmdArgs[1]);
                int enemyCol = int.Parse(cmdArgs[2]);

                armor--;

                matrix[enemyRow][enemyCol] = 'O';
                matrix[playerRow][playerCol] = '-';

                if(action == "up" && playerRow - 1>= 0)
                {
                    playerRow--;
                }
                else if(action == "down" && playerRow + 1>=0)
                {
                    playerRow++;
                }
                else if(action == "left" && playerCol -1 >=0)
                {
                    playerCol--;
                }
                else if(action == "right" && playerCol + 1 < matrix[playerRow].Length)
                {
                    playerCol++;
                }


                if(matrix[playerRow][playerCol] == 'O')
                {
                    armor -= 2;
                }
                else if(matrix[playerRow][playerCol] == 'M')
                {
                    matrix[playerRow][playerCol] = '-';
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                    break;
                }

                if(armor <= 0)
                {
                    matrix[playerRow][playerCol] = 'X';
                    Console.WriteLine($"The army was defeated at {playerRow};{playerCol}.");
                    break;
                }

                matrix[playerRow][playerCol] = 'A';
            }

            PrintMatrix(matrix);

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
