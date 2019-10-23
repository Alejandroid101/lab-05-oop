using System;
using System.Collections.Generic;
using System.Text;

namespace Zoop
{
    /// <summary>
    /// This is the base class
    /// </summary>
    public abstract class Animal
    {
        public string Name { get; set; }

        //defining abstract Methods (1 and 2)
        /// <summary>
        /// Defines the time the animal has been in the Zoo
        /// </summary>
        /// <returns>a string with time in zoo</returns>
        public abstract string TimeInZoo();
        /// <summary>
        /// Tells you if the animal is friendly by nature or not
        /// </summary>
        /// <returns>true or false friendliness</returns>
        public abstract bool Friendly();

        //defining a virtual method (1)
        public virtual int Genomes { get; set; }
    }
}
