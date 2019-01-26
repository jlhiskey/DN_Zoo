using DN_Zoo.Classes.Biologic_Class_Sub_Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Animals
{
    /// <summary>
    /// CONCRETE Crow class inheretes the properties of Sub Type Flying
    /// </summary>
    public class Crow : Flying
    {
        public override string SpeciesName { get; set; } = "Crow";

        public override string AnimalName { get; set; }

        public override int Age { get; set; }

        public override bool Raptor { get; set; } = false;

        public override bool HasVenom { get; set; } = false;

        public virtual string AnimalType()
        {
            return $"I am a {SpeciesName}.";
        }

         public override string Sound()
        {
            return "Kaw Kaaaa";
        }

    }
}
