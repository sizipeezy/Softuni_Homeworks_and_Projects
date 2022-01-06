using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class FirePotion : Item
    {
        private const int defaultWeight = 5;
        private const int defaultDecrease = 20;
        public FirePotion() : base(defaultWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Health -= defaultDecrease;
            if (character.Health <= 0)
            {
                character.IsAlive = false;
            }

        }
    }
}
