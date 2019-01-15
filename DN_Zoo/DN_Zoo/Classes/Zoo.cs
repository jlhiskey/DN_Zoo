using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes
{
    /// <summary>
    /// Zoo class allows a user to create a zoo with a name and a maximum population. It also allows a user to add animals to the zoo as objects.
    /// </summary>
     class Zoo
    {
        public string Name { get; set; }
        public int MaxAnimalCapacity { get; set; }
        public int CurrentPopulation { get; set; } = 0;
        public object[] CurrentAnimals { get; set; }

        public void setValues(object[] currentAnimals)
        { 
        currentAnimals = CurrentAnimals;
        int maxAnimalCapacity = MaxAnimalCapacity;
        int currentPopulation = CurrentPopulation;
        currentAnimals = new object[maxAnimalCapacity];
        CurrentAnimals = currentAnimals;
        }

        /// <summary>
        /// Allows user to add an animal to the zoo as an object. Checks current population compared to max population and will not let animal be added if population is max.
        /// </summary>
        /// <param name="newAnimal"></param>
        /// <returns>Checks the current population array and returns added animal as an object from population array.</returns>
        public object AddAnimal(object newAnimal)
        {
            object[] currentAnimals = CurrentAnimals;
            int maxAnimalCapacity = MaxAnimalCapacity;
            int currentPopulation = CurrentPopulation;
            if (currentAnimals == null)
            {
                setValues(currentAnimals);
                currentAnimals = CurrentAnimals;
            }
       
            if (maxAnimalCapacity > currentPopulation)
            {
                currentAnimals[currentPopulation] = newAnimal;
                currentPopulation = currentPopulation + 1;
                CurrentAnimals = currentAnimals;
                CurrentPopulation = currentPopulation;

                return currentAnimals[currentPopulation - 1];
            }
            else
            {
                Console.WriteLine("Zoo at Maximum Capacity");
                return null;
            }
        }

    }
}
