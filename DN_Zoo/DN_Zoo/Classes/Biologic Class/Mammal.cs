using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Biologic_Class
{
    public abstract class Mammal : BiologicClass
    {
        public override string ClassType { get; set; } = "Mammal";
        
        public abstract bool HasRetractableClaws { get; set; }

        public virtual string WhatClassAmI()
        {
            return "I am a Mammal.";
        }
    }
}
