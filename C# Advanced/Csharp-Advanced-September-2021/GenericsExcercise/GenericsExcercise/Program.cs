using System;

namespace GenericsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
               int item = int.Parse(Console.ReadLine());
                box.Add(item);
            }
            Console.WriteLine(box);

        }
    }
}
