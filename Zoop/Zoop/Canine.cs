using System;
using System.Collections.Generic;
using System.Text;

namespace Zoop
{
    public abstract class Canine : Animal
    {
        public bool Carnivore { get; set; } = true;
        public string Fur { get; set; }

        // defining abstract property (2)
        public abstract string Pack { get; set; }

        public virtual string CanineDescription()
        {
            return "All Canines are carnivores and mostly hunt in packs!";
        }

    }
}
