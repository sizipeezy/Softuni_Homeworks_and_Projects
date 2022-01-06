using System;

namespace LastPrep01
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double lectures = double.Parse(Console.ReadLine());

            double bonus = double.Parse(Console.ReadLine());


            double total = 0;
            double highest = 0;
            double highestAttend = 0;
            for (int i = 0; i < students; i++)
            {


                double attendances = double.Parse(Console.ReadLine());

                total = attendances / lectures * (5 + bonus);

                if (total > highest)
                {
                    highest = total;
                    highestAttend = attendances;
                }

            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(highest)}.");
            Console.WriteLine($"The student has attended {highestAttend}");


        }
    }
}
