using DN_Zoo.Classes.Biologic_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Biologic_Class_Sub_Types
{
    public abstract class Amphibian : Reptile
    {
        public override bool CanSwim { get; set; } = true;

        public abstract bool CanJump { get; set; }

        public virtual string WhatIsMySubtype()
        {
            return "I can swim.";
        }

    }
}
