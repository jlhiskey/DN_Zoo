using System;
using DN_Zoo.Classes;

namespace DN_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            BiologicClass mammal = new BiologicClass();
            mammal.Name = "Mammal";

            Food hay = new Food();
            hay.Name = "Hay";
            hay.Type = "Vegetarian";

            Medication mammalAntibiotic = new Medication();
            mammalAntibiotic.Name = "Mammal Antibiotic";
            mammalAntibiotic.BiologicClassRestrictions = mammal;

            Animal horse = new Animal();
            horse.Name = "Shadow Fax";
            horse.BiologicClass = mammal;
            horse.Food = hay;
            horse.Medications = mammalAntibiotic;
            
        }
    }
}
