using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        private string name;
        private double armor;
        private double health;

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            this.Name = name;
            this.Health = health;
            this.BaseHealth = health;
            this.Armor = armor;
            this.BaseArmor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
        }


        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }
                this.name = value;
            }
        }

        public double BaseHealth { get; }

        public double Health
        {
            get => this.health;
            set
            {
                if (value > this.BaseHealth)
                {
                    health = BaseHealth;
                }
                else if (value < 0)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }

            }
        }

        public double BaseArmor { get; }

        public double Armor
        {
            get => this.armor;
            set
            {
                if (value < 0)
                {
                    armor = 0;
                }
                else
                {
                    armor = value;
                }
            }
        }

        public double AbilityPoints { get; }

        public Bag Bag { get; set; }

        public bool IsAlive { get; set; } = true;

        protected void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }

        public virtual void TakeDamage(double hitPoints)
        {
            EnsureAlive();
            double healthReduce = hitPoints - this.Armor;
            this.Armor -= hitPoints;

            if (healthReduce > 0)
            {
                this.Health -= healthReduce;
            }

            if (this.Health == 0)
            {
                IsAlive = false;
            }
        }


        public virtual void UseItem(Item item)
        {
            EnsureAlive();
            item.AffectCharacter(this);
            
        }
    }
}