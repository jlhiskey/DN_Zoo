using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes
{
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

        //Add Animal
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

        //Remove Animal
    }
}
