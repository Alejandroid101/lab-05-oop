using System;
using System.Collections.Generic;
using System.Text;

namespace Zoop
{
    public class Wolf : Canine
    {
        //overriding abstract Pack property
        public override string Pack { get; set; }

        public override bool Friendly()
        {
            return false;
        }

        public override string TimeInZoo()
        {
            return "I have been in the zoo for 7 years";
        }
        public override string CanineDescription()
        {
            return "Wolves hunt in packs, there is always an alpha dog";
        }
    }
}
