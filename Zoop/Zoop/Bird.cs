using System;
using System.Collections.Generic;
using System.Text;

namespace Zoop
{
    public abstract class Bird : Animal
    {
        public virtual bool Flies { get; set; } = true;
        public string Beak { get; set; }
        public string Omnivore { get; set; }

        // defining an virtual method (1)
        public virtual string BirdDescription()
        {
            return "Birds have feathers";
        }

        //calling the IPettingZoo Interface
    }


}
