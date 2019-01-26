using DN_Zoo.Classes.Biologic_Class_Sub_Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Animals
{
    /// <summary>
    /// CONCRETE Eagle class inheretes the properties of the Sub Type Flying.
    /// </summary>
    public class Eagle : Flying
    {
        public override string SpeciesName { get; set; } = "Eagle";

        public override string AnimalName { get; set; }

        public override int Age { get; set; }

        public override bool Raptor { get; set; } = true;

        public virtual string AnimalType()
        {
            return $"I am a {SpeciesName}.";
        }

        public override string Sound()
        {
            return "Ammeerriiccaaaa!!!!";
        }
    }
}
