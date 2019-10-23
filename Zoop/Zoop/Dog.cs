using System;
using System.Collections.Generic;
using System.Text;

namespace Zoop
{
    public class Dog : Canine, IPettingZoo, ITrainnedAnimal
    {

        public override string Pack { get; set; }

        //overriding Friendly abstract method
        public override bool Friendly()
        {
            return true;
        }

        //overrigind TimeInZoo  abstract method
        public override string TimeInZoo()
        {
            return "I have been in the zoo for 2 years";
        }

        public override string CanineDescription()
        {
            return "Man's best friend";
        }
        //calling for the ITrainnedAnimal Interface
        public string Trainned()
        {
            return "I Am trainned to assist blind people on the streets!";
        }
        public string PetMe()
        {
            return "I will let you pet me as long as you are gentle";
        }
    }
}
