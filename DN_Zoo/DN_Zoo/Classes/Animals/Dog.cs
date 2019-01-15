using DN_Zoo.Classes.Biologic_Class_Sub_Types;
using DN_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Animals
{
    public class Dog : Canine, IBite
    {
        public override string SpeciesName { get; set; } = "Dog";

        public override string AnimalName { get; set; }

        public override int Age { get; set; }

        public override bool CanBeDomesticated { get; set; } = true;

        public virtual string AnimalType()
        {
            return $"I am a {SpeciesName}.";
        }

        public override string Bite()
        {
            Console.WriteLine("Im domesticated I don't Bite");

            return "Don't Bite";
        }

    }
}
