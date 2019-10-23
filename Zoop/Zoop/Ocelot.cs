using System;
using System.Collections.Generic;
using System.Text;

namespace Zoop
{
    public class Ocelot : Feline
    {

        //overriding Roars property from Feline
        private string _roars = "Ocelot is roaring";
        public override string Roars { get { return _roars; } set { _roars = value; } }

        public string Claws()
        {
            return "This animal has big claws that allow it to climb trees";
        }

        //overriding Friendly method from base class Animal
        public override bool Friendly()
        {
            return true;
        }

        //overriding Friendly method from base class Animal
        public override string TimeInZoo()
        {
            return "I have been in the zoo for 5 years";
        }
    }
}
