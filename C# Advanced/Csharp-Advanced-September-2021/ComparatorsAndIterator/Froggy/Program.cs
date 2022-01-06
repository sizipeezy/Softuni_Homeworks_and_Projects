using System;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var lake = new Lake();

            var data = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            lake = new Lake(data);


            Console.WriteLine(string.Join(", ", lake));
        }

    }
}
