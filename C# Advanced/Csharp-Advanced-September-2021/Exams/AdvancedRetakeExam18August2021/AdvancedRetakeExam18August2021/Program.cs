using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] guestCapacity = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] platesFood = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            Stack<int> plates = new Stack<int>(platesFood);
            Queue<int> guests = new Queue<int>(guestCapacity);

            int wastedFood = 0;
            int currentSum = 0;
            bool flag = false;
            bool noBottles = false;
            while (true)
            {
                int currentGuest = guests.Peek();
                int currentPlate = plates.Peek();

                if (!guests.Any())
                {
                    flag = true;
                    break;
                }
                else if (!plates.Any())
                {
                    noBottles = true;
                    break;
                }


                if (currentPlate >= currentGuest)
                {
                    currentSum = currentPlate - currentGuest;
                    wastedFood += currentSum;
                    plates.Pop();
                    guests.Dequeue();


                }
                else
                {
                    currentGuest -= currentPlate;
                    plates.Pop();
                }
                
            }



            if (flag == true)
            {
                Console.WriteLine($"BPlates: {string.Join(" ", plates)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
            else if (noBottles == true)
            {
                Console.WriteLine($"Guests: {string.Join(" ", guests)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
        }
    }
}
