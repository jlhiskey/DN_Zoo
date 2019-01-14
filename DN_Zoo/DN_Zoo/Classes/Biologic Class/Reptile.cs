using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Biologic_Class
{
    public abstract class Reptile : BiologicClass
    {
        public override string ClassType { get; set; } = "Reptile";

        public abstract bool CanSwim { get; set; }
    }
}
