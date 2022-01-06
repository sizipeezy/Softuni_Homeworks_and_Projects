using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Models.Workshops
{
    public class Workshop : IWorkshop
    {
        public void Color(IEgg egg, IBunny bunny)
        {
            
            while(bunny.Energy > 0 && (!egg.IsDone()))
            {
                if(bunny.Energy == 0)
                {
                    break;
                }

                if (bunny.Dyes.All(x => x.IsFinished()))
                {
                    break;
                }

                
          
                bunny.Work();
                egg.GetColored();

                
            }
        }
    }
}
