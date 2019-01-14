using DN_Zoo.Classes.Biologic_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Biologic_Class_Sub_Types
{
    public abstract class Canine : Mammal
    {
        public override bool HasRetractableClaws { get; set; } = false;

        public abstract bool CanBeDomesticated { get; set; }

    }
}
