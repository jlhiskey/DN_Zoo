using DN_Zoo.Classes.Biologic_Class_Sub_Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Animals
{
    /// <summary>
    /// CONCRETE Emu class inheretes the properties of the Sub Type NonFlying.
    /// </summary>
    public class Emu : NonFlying
    {
        public override string SpeciesName { get; set; } = "Emu";

        public override string AnimalName { get; set; }

        public override int Age { get; set; }

        public override bool IsBlackAndWhite { get; set; } = false;

        public virtual string AnimalType()
        {
            return $"I am a {SpeciesName}.";
        }

        public override string WhatColorAmI()
        {
            return "I am brown";
        }
    }
}
