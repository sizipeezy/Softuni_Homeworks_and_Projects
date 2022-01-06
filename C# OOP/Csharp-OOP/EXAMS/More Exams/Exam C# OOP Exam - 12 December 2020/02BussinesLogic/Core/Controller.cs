using Bakery.Core.Contracts;
using Bakery.Models.BakedFoods;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Core
{
    public class Controller : IController
    {
        private  ICollection<IBakedFood> bakedFoods;
        private  ICollection<IDrink> drinks;
        private  ICollection<ITable> tables;

        private decimal TotalRestaurantIncome;
        public Controller()
        {
            this.bakedFoods = new List<IBakedFood>();
            this.drinks = new List<IDrink>();
            this.tables = new List<ITable>();
            this.TotalRestaurantIncome = 0;

        }
        public string AddDrink(string type, string name, int portion, string brand)
        {
            IDrink drink = null;

            if(type == "Tea")
            {
                drink = new Tea(name, portion, brand);
            }
            else if(type == "Water")
            {
                drink = new Water(name, portion, brand);
            }

            drinks.Add(drink);

            return string.Format(OutputMessages.DrinkAdded, name, brand);
        }

        public string AddFood(string type, string name, decimal price)
        {
            IBakedFood food = null;
            if(type == "Cake")
            {
                food = new Cake(name, price);
            }
            else if(type == "Bread")
            {
                food = new Bread(name, price);
            }

            this.bakedFoods.Add(food);

            return string.Format(OutputMessages.FoodAdded, name, type);
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            ITable table = null;
            if(type == "InsideTable")
            {
                table = new InsideTable(tableNumber, capacity);
            }
            else if(type == "OutsideTable")
            {
                table = new OutsideTable(tableNumber, capacity);
            }

            this.tables.Add(table);

            return string.Format(OutputMessages.TableAdded, tableNumber);
        }

        public string GetFreeTablesInfo()
        {
            var notReserved = this.tables.Where(x => x.IsReserved == false)
               .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var table in notReserved)
            {
                sb.AppendLine(table.GetFreeTableInfo());
            }

            return sb.ToString().TrimEnd();
        }

        public string GetTotalIncome()
        {
            return string.Format(OutputMessages.TotalIncome, TotalRestaurantIncome);

        }

        public string LeaveTable(int tableNumber)
        {
            ITable table = tables.FirstOrDefault(t => t.TableNumber == tableNumber);

            if (table == null)
            {
                throw new ArgumentException(string.Format(OutputMessages.WrongTableNumber, tableNumber));
            }

            var totalTableSum = table.GetBill();

            this.TotalRestaurantIncome += totalTableSum;

            table.Clear();

            var sb = new StringBuilder();
            sb.AppendLine($"Table: {tableNumber}");
            sb.AppendLine($"Bill: {totalTableSum:f2}");

            return sb.ToString().TrimEnd();
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            ITable table = this.tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            IDrink drink = this.drinks.FirstOrDefault(c => c.Name == drinkName
            && c.Brand == drinkBrand);

            if(table == null)
            {
                return string.Format(OutputMessages.WrongTableNumber, tableNumber);
            }

            if(drink == null)
            {
                return string.Format(OutputMessages.NonExistentDrink, drinkName, drinkBrand);
            }

            table.OrderDrink(drink);
            return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            ITable table = this.tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            IBakedFood food = this.bakedFoods.FirstOrDefault(x => x.Name == foodName);

            if(table == null)
            {
                return string.Format(OutputMessages.WrongTableNumber, tableNumber);
            }

            if(food == null)
            {
                return string.Format(OutputMessages.NonExistentFood, foodName);
            }

            table.OrderFood(food);
            return string.Format(OutputMessages.FoodOrderSuccessful, tableNumber, foodName);
        }

        public string ReserveTable(int numberOfPeople)
        {
            ITable table = this.tables.FirstOrDefault(x => x.IsReserved == false
            && x.Capacity >= numberOfPeople);

            if(table == null)
            {
                return string.Format(OutputMessages.ReservationNotPossible, numberOfPeople);
            }
            else
            {
                table.Reserve(numberOfPeople);
                return string.Format(OutputMessages.TableReserved, table.TableNumber, numberOfPeople);
            }
        }
    }
}
