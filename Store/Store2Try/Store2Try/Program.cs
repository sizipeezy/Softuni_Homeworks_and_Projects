using System;
using System.Collections.Generic;
using System.Linq;

namespace Store2Try
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Product, int> cart = new Dictionary<Product, int>();


            Product food = new Food("apples", "BrandA", 1.50, "14-06-2022");
            cart.Add(food, 2);

            Product beverage = new Beverage("milk", "BrandM", 0.99, "02-02-2022");
            cart.Add(beverage, 3);

            Product clothes = new Clothes("T-shirt", "BrandT", 15.99, "M", "violet");
            cart.Add(clothes, 2);

            Product appliance = new Appliances("laptop", "BrandL", 2345, "ModelL", "03-03-2021", 1.25);
            cart.Add(appliance, 1);

            
            string date = "13/01/2022";
            Cashier cashier = new Cashier();
          
            Console.WriteLine(cashier.Print(cart, date));
         
        }
    }
}
