﻿using System;

namespace string02
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine.We don't have anything else. " +
                "Inside the submarine is very tight. So we are drinking all the"+
                "day.We will move out of it in 5 days.";

            string result = "";

            int counter = 0;

            foreach (string item in text)
            {
                if(item == "in")
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);

        }
    }
}
