using Easter.Models.Dyes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Dyes
{
    public class Dye : IDye
    {
        public Dye(int power)
        {
            this.Power = power;
        }
        public int Power { get; private set; }

        public bool IsFinished()
        {
            if(this.Power  == 0)
            {
                return true;
            }

            return false;
        }

        public void Use()
        {
            if(this.Power < 0)
            {
                this.Power = 0;
            }
        }
    }
}
