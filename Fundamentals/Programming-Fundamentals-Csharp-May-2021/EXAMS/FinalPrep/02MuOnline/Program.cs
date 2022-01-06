using System;
using System.Linq;

namespace _02MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHealth = 100;
            int bitcoins = 0;

            string[] rooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int gameHealth = startHealth;
            int currentHealth = startHealth;

            bool hasToBreak = true;
            string input = string.Empty;



            int bestRoom = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] cmdArgs = rooms[i].Split(" ");
                string command = cmdArgs[0];
                int number = int.Parse(cmdArgs[1]);


                bestRoom++;

                if (command == "potion")
                {
                    if (gameHealth < 100)
                    {
                        int health = gameHealth;

                        gameHealth += number;
                        if (gameHealth > 100)
                        {
                            gameHealth = 100;
                            int amount = 100 - health;
                            Console.WriteLine($"You healed for {amount} hp.");
                            Console.WriteLine($"Current health: {gameHealth} hp.");
                        }
                        else
                        {
                            Console.WriteLine($"You healed for {number} hp.");
                            Console.WriteLine($"Current health: {gameHealth} hp.");
                        }


                    }


                }
                else if (command == "chest")
                {
                    int gold = number;
                    Console.WriteLine($"You found {number} bitcoins.");
                    bitcoins += gold;
                }
                else
                {
                    int attack = number;
                    gameHealth -= attack;
                    if (gameHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        hasToBreak = false;
                        break;

                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command}.");

                    }
                }


            }
            if (hasToBreak)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {gameHealth}");
            }
        }
        
    }
}
