﻿using Easter.Models.Eggs.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Eggs
{
    public class Egg : IEgg
    {
        private string name;
        private int energyRequired;

        public Egg(string name, int energyRequired)
        {
            this.Name = name;
            this.EnergyRequired = energyRequired;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Egg name cannot be null or empty.");
                }
                this.name = value;
            }
        }
        public int EnergyRequired
        {
            get => this.energyRequired;
            private set
            {
                if(value < 0)
                {
                    value = 0;
                }

                this.energyRequired = value;
            }
        }

        public void GetColored()
        {
            this.EnergyRequired -= 10;
            if(this.EnergyRequired < 0)
            {
                this.EnergyRequired = 0;
            }
        }

        public bool IsDone()
        {
            if(this.EnergyRequired == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
