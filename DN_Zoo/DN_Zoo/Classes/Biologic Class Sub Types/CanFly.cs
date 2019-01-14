using DN_Zoo.Classes.Biologic_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Biologic_Class_Sub_Types
{
    public abstract class Flying : Avian
    {
        public override bool CanFly { get; set; } = true;

        public abstract bool Raptor { get; set; }

    }
}
