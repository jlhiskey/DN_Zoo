﻿using DN_Zoo.Classes.Biologic_Class_Sub_Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Animals
{
    /// <summary>
    /// CONCRETE HouseCat class inheretes the properties of the Sub Type Feline.
    /// </summary>
    public class HouseCat : Feline
    {
        public override string SpeciesName { get; set; } = "HouseCat";
        
        public override string AnimalName { get; set; }

        public override int Age { get; set; }

        public override bool CanBeDomesticated { get; set; } = true;

        public virtual string AnimalType()
        {
            return $"I am a {SpeciesName}.";
        }

    }
}
