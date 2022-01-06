using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightforGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            var waves = int.Parse(Console.ReadLine());
            var plates = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            var orcsToPrint = new Queue<int>();
            for (int i = 1; i <= waves; i++)
            {
                var newWaveOrcs = new Stack<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse));

                var curPlate = plates.Peek();
                if (i % 3 == 0)
                {
                    string input = Console.ReadLine();
                    int plateToAdd = int.Parse(input);
                    plates.Enqueue(plateToAdd);
                }
                while (newWaveOrcs.Count != 0 && plates.Count != 0)
                {
                    var curOrc = newWaveOrcs.Peek();
                    if (curPlate - curOrc > 0)
                    {
                        curPlate -= curOrc;
                        newWaveOrcs.Pop();
                    }
                    else if (curOrc > curPlate)
                    {
                        int orcToPrint = Math.Abs(curPlate - curOrc);
                        orcsToPrint.Enqueue(orcToPrint);
                        newWaveOrcs.Pop();
                        plates.Dequeue();
                        if (plates.Count == 0)
                        {
                            break;
                        }
                        else
                        {
                            curPlate = plates.Peek();
                        }
                    }
                    else
                    {
                        plates.Dequeue();
                        newWaveOrcs.Pop();
                    }
                }
                if (newWaveOrcs.Count > 0 && plates.Count == 0)
                {
                    for (int j = 0; j < newWaveOrcs.Count; j++)
                    {
                        orcsToPrint.Enqueue(newWaveOrcs.Pop());
                    }
                    break;
                }

            }

            if (plates.Count <= 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcsToPrint)}");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }
            
    }
}
