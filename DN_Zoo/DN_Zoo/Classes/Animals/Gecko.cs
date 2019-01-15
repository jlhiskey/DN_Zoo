using DN_Zoo.Classes.Biologic_Class_Sub_Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Animals
{
    /// <summary>
    /// CONCRETE Gecko class inheretes the properties of the Sub Type NonAmphibian.
    /// </summary>
    public class Gecko : NonAmphibian
    {
        public override string SpeciesName { get; set; } = "Gecko";

        public override string AnimalName { get; set; }

        public override int Age { get; set; }

        public override bool HasLegs { get; set; } = true;

        public virtual string AnimalType()
        {
            return $"I am a {SpeciesName}.";
        }
    }
}
