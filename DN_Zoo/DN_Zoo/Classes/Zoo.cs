using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes
{
    abstract class Zoo
    {
        public int MaxAnimalCapacity { get; set; }
        public int currentPopulation { get; set; }
        public object[] CurrentAnimals { get; set; }

        //Add Animal
        public object AddAnimal(object newAnimal)
        {
            if (MaxAnimalCapacity > currentPopulation)
            {

            }
        }

        //Remove Animal
    }
}
