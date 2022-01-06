using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private IList<IAquarium> aquariums;
        public Controller()
        {
            this.decorations = new DecorationRepository();
            this.aquariums = new List<IAquarium>();
        }
        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium = null;
            if (aquariumType == "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException("Invalid aquarium type.");
            }

            this.aquariums.Add(aquarium);
            var result = string.Format($"Successfully added {aquariumType}.");

            return result;
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration = null;
            if (decorationType == "Ornament")
            {
                decoration = new Ornament();
            }
            else if (decorationType == "Plant")
            {
                decoration = new Plant();
            }
            else
            {
                throw new InvalidOperationException($"Invalid decoration type.");
            }

            this.decorations.Add(decoration);

            var result = string.Format($"Successfully added {decorationType}.");

            return result;
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IAquarium aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
            IFish fish = null;
            if (fishType == "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
            }
            else if (fishType == "SaltwaterFish")
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                throw new InvalidOperationException("Invalid fish type.");
            }

            if (fish.GetType().Name != "FreshwaterFish" && aquarium.GetType().Name != "SaltwaterAquarium")
            {
                string result = "Water not suitable.";
                return result;
              
            }

            if (fish.GetType().Name != "SaltwaterFish" && aquarium.GetType().Name != "FreshwaterAquarium")
            {
                string result = "Water not suitable.";
                return result;
                
            }

            aquarium.AddFish(fish);
            string message = string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);

            return message;
        }

        public string CalculateValue(string aquariumName)
        {
            var aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
            var totalPrice = aquarium.Fish.Sum(x => x.Price) +
                aquarium.Decorations.Sum(p => p.Price);

            string result = string.Format(OutputMessages.AquariumValue, aquariumName, totalPrice);

            return result;
            
                    
        }

        public string FeedFish(string aquariumName)
        {
            var aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
            foreach (var item in aquarium.Fish)
            {
                item.Eat();
            }

            string result  = string.Format(OutputMessages.FishFed, aquarium.Fish.Count);
            return result;
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            var aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
            var decoration = this.decorations.FindByType(decorationType);
            if (decoration == null)
            {
                throw new InvalidOperationException(string.Format($"There isn't a decoration of type {decorationType}."));
            }

            aquarium.AddDecoration(decoration);
            this.decorations.Remove(decoration);

            var message = string.Format($"Successfully added {decorationType} to {aquariumName}.");

            return message;
        }

        public string Report()
        {
            string result = "";

            foreach (var aquaruim in aquariums)
            {
                result += aquaruim.GetInfo() + "\r\n";
            }

            return result.Trim();
        }
    }
}
