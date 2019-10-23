using System;
using System.Collections.Generic;
using System.Text;

namespace Zoop
{
    public class Hawk : Bird
    {
        public new string Name { get; set; }
        public override string BirdDescription()
        {
            return "I hunt other birds and feed from small mammals";
        }
        public override int Genomes { get; set; }

        
        // overriding Friendly abstract method
        public override bool Friendly()
        {
            return false;
        }

        //overriding TimeInZoo abstract method
        public override string TimeInZoo()
        {
            return "I have been in the zoo for 3 years";
        }
        //calling for the ITrainnedAnimal Interface
        public string Trainned()
        {
            return "I Am trainned to hunt pigeons at the airport!";
        }
    }
}
