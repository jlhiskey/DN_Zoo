using DN_Zoo.Classes.Biologic_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Biologic_Class_Sub_Types
{
    /// <summary>
    /// ABSTRACT NonFlying class inheretes the properties of the Biologic Class Avian.
    /// </summary>
    public abstract class NonFlying : Avian
    {
        public override bool CanFly { get; set; } = false;

        public abstract bool IsBlackAndWhite { get; set; }

        public virtual string WhatIsMySubtype()
        {
            return "I can't fly.";
        }

        public abstract string WhatColorAmI();
    }
}


