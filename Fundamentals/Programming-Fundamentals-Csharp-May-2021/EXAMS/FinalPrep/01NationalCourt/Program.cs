using System;

namespace _01NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());

            int peopleCount = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = employee1 + employee2 + employee3;
            while(peopleCount != 0)
            {
              
                peopleCount -= sum;
                counter++;
              

                if(counter % 4 == 0)
                {
                    counter++;
                }
                if (peopleCount <= 0)
                {
                    break;
                }

            }

            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
