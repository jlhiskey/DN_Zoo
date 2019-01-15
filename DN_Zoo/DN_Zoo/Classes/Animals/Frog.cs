using DN_Zoo.Classes.Biologic_Class_Sub_Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Animals
{
    public class Frog : Amphibian
    {
        /// <summary>
        /// CONCRETE Frog class inheretes the properties of the Sub Type Amphibian.
        /// </summary>
        public override string SpeciesName { get; set; } = "Frog";

        public override string AnimalName { get; set; }

        public override int Age { get; set; }

        public override bool CanJump { get; set; } = true;

        public virtual string AnimalType()
        {
            return $"I am a {SpeciesName}.";
        }
    }
}
