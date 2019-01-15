using DN_Zoo.Classes.Biologic_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Biologic_Class_Sub_Types
{
    /// <summary>
    /// ABSTRACT Feline class inheretes the properties of the Biologic Class Mammal.
    /// </summary>
    public abstract class Feline : Mammal
    {
        public override bool HasRetractableClaws { get; set; } = true;

        public abstract bool CanBeDomesticated { get; set; }

        public virtual string WhatIsMySubtype()
        {
            return "I am a Feline.";
        }
    }
}
