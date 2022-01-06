using System;
using System.Linq;

namespace _01MidEXam_TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int peopleOnCurrWagon = 0;
            int peopleOnLift = 0;
            bool NoMorePeople = false;

            for (int i = 0; i < wagons.Length; i++)
            {
                while (wagons[i] < 4)
                {
                    wagons[i]++;
                    peopleOnCurrWagon++;
                    if (peopleOnLift + peopleOnCurrWagon == people)
                    {
                        NoMorePeople = true;
                        break;
                    }

                }
                peopleOnLift += peopleOnCurrWagon;
                if (NoMorePeople)
                {
                    break;
                }

                peopleOnCurrWagon = 0;
            }

            if (people > peopleOnLift)
            {
                Console.WriteLine($"There isn't enough space! {people - peopleOnLift} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (people < wagons.Length * 4 && wagons.Any(w => w < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (wagons.All(w => w == 4) && NoMorePeople == true)
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}
