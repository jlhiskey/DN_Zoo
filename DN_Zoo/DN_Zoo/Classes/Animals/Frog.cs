using DN_Zoo.Classes.Biologic_Class_Sub_Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Animals
{
    class Frog : Amphibian
    {
        public override string SpeciesName { get; set; } = "Frog";

        public override string AnimalName { get; set; }

        public override int Age { get; set; }

        public override bool CanJump { get; set; } = true;
    }
}
