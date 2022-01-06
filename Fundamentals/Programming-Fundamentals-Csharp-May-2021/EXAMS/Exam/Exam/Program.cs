using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double boudget = double.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            double flour = double.Parse(Console.ReadLine());
            double eggPriceOne = double.Parse(Console.ReadLine());
            double appronPriceOne = double.Parse(Console.ReadLine());


            double appronBonus = students * 0.20;

            int counterFlour = 0;

            double result = 0;

          //  while (flour != 0)
           // //{
            //    if (flour % 5 == 0)
            //    {
           //         counterFlour++;
            //    }
            //    flour -= 5;
          //  }
        //    
            if(students % 5 == 0)
            {
                counterFlour+=5;
            }
            result = appronPriceOne * (Math.Ceiling(students +appronBonus)) + eggPriceOne * 10 * (students) + flour * (students - counterFlour);

           

            if(result < boudget)
            {
                Console.WriteLine($"Items purchased for {result:f2}$.");
            }
            else
            {
                Console.WriteLine($"{result - boudget:f2}$ more needed.");
            }
        }

    }
}
