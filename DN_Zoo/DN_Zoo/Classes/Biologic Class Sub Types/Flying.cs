using DN_Zoo.Classes.Biologic_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Biologic_Class_Sub_Types
{
    /// <summary>
    /// ABSTRACT Flying class inheretes the properties of the Biologic Class Avian.
    /// </summary>
    public abstract class Flying : Avian
    {
        public override bool CanFly { get; set; } = true;

        public abstract bool Raptor { get; set; }

        public virtual string WhatIsMySubtype()
        {
            return "I can fly.";
        }

        public abstract string Sound();
        
        

    }
}
