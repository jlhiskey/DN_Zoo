using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Biologic_Class
{
    public abstract class Avian : BiologicClass
    {
        public override string ClassType { get; set; } = "Avian";

        public abstract bool CanFly { get; set; }

        public virtual string WhatClassAmI()
        {
            return $"I am a {ClassType}.";
        }
    }
}
