using DN_Zoo.Classes.Biologic_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Biologic_Class_Sub_Types
{
    /// <summary>
    /// ABSTRACT NonAmphibian class inheretes the properties of the Biologic Class Reptile.
    /// </summary>
    public abstract class NonAmphibian : Reptile
    {
        public override bool CanSwim { get; set; } = false;

    public abstract bool HasLegs { get; set; }

        public virtual string WhatIsMySubtype()
        {
            return "I can't swim.";
        }

    }
}