using System;
using System.Collections.Generic;
using System.Linq;

namespace _01MidExam_ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHelth = int.Parse(Console.ReadLine());
            string comand = null;
            bool yes = false;

            while ((comand = Console.ReadLine()) != "Retire")
            {
                string[] comnd = comand.Split(" ");
                if (comnd[0] == "Fire")
                {
                    int index = int.Parse(comnd[1]);
                    int damage = int.Parse(comnd[2]);
                    if (index >= 0 && index <= pirateShip.Count)
                    {
                        int afterFire = warShip[index];
                        afterFire = afterFire - damage;
                        if (afterFire <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            yes = true;
                        }
                        else
                        {
                            warShip.RemoveAt(index);
                            warShip.Insert(index, afterFire);
                        }
                    }
                }
                else if (comnd[0] == "Defend")
                {
                    int startIndex = int.Parse(comnd[1]);
                    int endIndex = int.Parse(comnd[2]);
                    int damage = int.Parse(comnd[3]);
                    if (startIndex >= 0 && endIndex <= pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            int indexNumber = i;
                            int result = pirateShip[indexNumber] - damage;
                            if (result <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                yes = true;
                                break;
                            }
                            else
                            {
                                pirateShip.Remove(pirateShip[indexNumber]);
                                pirateShip.Insert(startIndex, result);
                                startIndex++;
                            }
                        }
                    }
                }
                else if (comnd[0] == "Repair")
                {
                    int index = int.Parse(comnd[1]);
                    int helth = int.Parse(comnd[2]);
                    if (index >= 0 && index <= pirateShip.Count)
                    {
                        if (helth > maxHelth)
                        {
                            helth = maxHelth;
                            pirateShip.RemoveAt(index);
                            pirateShip.Insert(index, helth);
                        }
                        else
                        {
                            int num = pirateShip[index];
                            pirateShip.RemoveAt(index);
                            pirateShip.Insert(index, helth + num);
                        }
                    }
                }
                else if (comnd[0] == "Status")
                {
                    int count = 0;
                    double percent = maxHelth * 0.2;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        int one = pirateShip[i];
                        if (percent > one)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }
                if (yes)
                {
                    break;
                }
            }
            if (yes == false)
            {
                int sum1 = 0;
                int sum2 = 0;
                for (int i = 0; i < pirateShip.Count; i++)
                {
                    sum1 += pirateShip[i];
                }
                Console.WriteLine($"Pirate ship status: {sum1}");
                for (int j = 0; j < warShip.Count; j++)
                {
                    sum2 += warShip[j];
                }
                Console.WriteLine($"Warship status: {sum2}");
            }
        }
    }
}
