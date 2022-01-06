using Easter.Core.Contracts;
using Easter.Models.Bunnies;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops;
using Easter.Models.Workshops.Contracts;
using Easter.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Core
{
    public class Controller : IController
    {
        private BunnyRepository bunnies;
        private EggRepository eggs;

        public Controller()
        {
            this.bunnies = new BunnyRepository();
            this.eggs = new EggRepository();
        }
        public string AddBunny(string bunnyType, string bunnyName)
        {
            IBunny bunny = null;
            if(bunnyType == "HappyBunny")
            {
                bunny = new HappyBunny(bunnyName);
            }
            else if(bunnyType == "SleepyBunny")
            {
                bunny = new SleepyBunny(bunnyName);
            }
            else
            {
                throw new InvalidOperationException($"Invalid bunny type.");
            }

            this.bunnies.Add(bunny);
            return string.Format($"Successfully added {bunnyType} named {bunnyName}.");

        }

        public string AddDyeToBunny(string bunnyName, int power)
        {

            IDye dye = new Dye(power);
            IBunny bunny = bunnies.FindByName(bunnyName);
            if (bunny == null)
            {
                throw new InvalidOperationException("The bunny you want to add a dye to doesn't exist!");
            }

            bunny.AddDye(dye);
            return string.Format($"Successfully added dye with power {power} to bunny {bunnyName}!");
        }

        public string AddEgg(string eggName, int energyRequired)
        {

            IEgg egg = new Egg(eggName, energyRequired);

            this.eggs.Add(egg);

            return string.Format($"Successfully added egg: {eggName}!");
        }

        public string ColorEgg(string eggName)
        {
            var suitable  =
                bunnies.Models.Where(x => x.Energy >= 50).OrderByDescending(x => x.Energy).ToList();

            IEgg egg = this.eggs.FindByName(eggName);
            IWorkshop workshop = new Workshop();

            if(suitable.Any() == false)
            {
                throw new InvalidOperationException("There is no bunny ready to start coloring!");
            }


            while (suitable.Any())
            {
                IBunny currentBunny = suitable.First();

                while (true)
                {
                    if (currentBunny.Energy == 0 || currentBunny.Dyes.All(x => x.IsFinished()))
                    {
                        suitable.Remove(currentBunny);
                        break;
                    }

                    workshop.Color(egg, currentBunny);

                    if (egg.IsDone())
                    {
                        break;
                    }
                }

                if (egg.IsDone())
                {
                    break;
                }
            }

            return $"Egg {eggName} is {(egg.IsDone() ? "done" : "not done")}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{eggs.Models.Count(x => x.IsDone())} eggs are done!");
            sb.AppendLine($"Bunnies info:");

            foreach (IBunny bunny in bunnies.Models)
            {
                sb.AppendLine($"Name: {bunny.Name}");
                sb.AppendLine($"Energy: {bunny.Energy}");
                sb.AppendLine($"Dyes: {bunny.Dyes.Count(x => !x.IsFinished())} not finished");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
