using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Priest : Character, IHealer
    {
        private const double defaultHealth = 50;
        private const double defaultArmor = 25;
        private const double defaultAbilityPoints = 40;
        // backpack bag
        public Priest(string name) 
            : base(name, defaultHealth, defaultArmor, defaultAbilityPoints, new Backpack())
        {
        }

        public void Heal(Character character)
        {
            this.EnsureAlive();
            if (!character.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }

            character.Health += AbilityPoints;
        }
    }
}
