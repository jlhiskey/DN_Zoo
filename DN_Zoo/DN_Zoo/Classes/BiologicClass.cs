using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes
{
    public abstract class BiologicClass
    {
        public abstract string SpeciesName { get; set; }
        public abstract string AnimalName { get; set; }
        public abstract int Age { get; set; }
        public abstract string ClassType { get; set; }

        public virtual string AmIAlive()
        {
            return "I am an animal.";
        }
    }
}
