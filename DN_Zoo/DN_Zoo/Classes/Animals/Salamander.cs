using DN_Zoo.Classes.Biologic_Class_Sub_Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Animals
{
    /// <summary>
    /// CONCRETE Salamander class inheretes the properties of the Sub Type Amphibian.
    /// </summary>
    public class Salamander : Amphibian
    {
        public override string SpeciesName { get; set; } = "Salamander";

        public override string AnimalName { get; set; }

        public override int Age { get; set; }

        public override bool CanJump { get; set; } = false;

        public virtual string AnimalType()
        {
            return $"I am a {SpeciesName}.";
        }
    }
}
