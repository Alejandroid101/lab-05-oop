using System;
using System.Collections.Generic;
using System.Text;

namespace Zoop
{
    public class Chicken : Bird, IPettingZoo
    {
        //overriding BirdDescription method from Bird class
        public override string BirdDescription()
        {
            return "This bird has wings, but cannot fly";
        }
        public override bool Flies { get; set; } = false;

        public override bool Friendly()
        {
            return true;
        }

        public override string TimeInZoo()
        {
            return "I have been in the zoo for 6 months";
        }
        public string PetMe()
        {
            return "I will let you pet me as long as you Bok BOK!!!";
        }
    }
}