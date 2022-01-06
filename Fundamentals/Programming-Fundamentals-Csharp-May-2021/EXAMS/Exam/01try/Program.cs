
using System;

namespace _01try
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());

            decimal studnets = decimal.Parse(Console.ReadLine());

            decimal flour = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal appronPrice = decimal.Parse(Console.ReadLine());


            decimal appronsBonus = (studnets * (decimal)0.20);
            int eggs = 10;

            decimal result = 0;
            decimal flourPackages = 0;


            if (studnets % 5 == 0)
            {
                flourPackages += 5;
            }
            decimal appronSum = appronPrice * (Math.Ceiling(studnets + appronsBonus));
            decimal eggSum = eggPrice * eggs * studnets;
            decimal flourSum = flour * (studnets - flourPackages);





            result = appronSum + eggSum + flourSum;

            if(result > budget)
            {
                Console.WriteLine($"{result- budget:f2}$ more needed.");
            }

            else
            {
                Console.WriteLine($"Items purchased for {result:f2}$.");
            }



        }
    }
}
