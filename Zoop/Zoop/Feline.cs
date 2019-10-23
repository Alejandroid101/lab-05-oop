using System;
using System.Collections.Generic;
using System.Text;

namespace Zoop
{

    public abstract class Feline : Animal
    {
        public new string Name { get; set; }
        public string NightVision { get; set; }
        public bool Fangs { get; set; } = true;

        //defining an abstract property (1)
        public abstract string Roars { get; set; }

        public void FelineDescription()
        {
            Console.WriteLine("All Felines are carnivores and great hunters!");
        }
    }
}
