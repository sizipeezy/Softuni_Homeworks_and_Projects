using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class HealthPotion : Item
    {
        private const int defaultWeight = 5;
        private const int defaultHealthIncrease = 20;
        public HealthPotion() : base(defaultWeight)
        {


        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);

            character.Health += defaultHealthIncrease;
        }
    }

}
