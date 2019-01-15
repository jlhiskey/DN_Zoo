using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Biologic_Class
{
    /// <summary>
    /// ABSTRACT Avian class inheretes the properties of the Base Class Animal.
    /// </summary>
    public abstract class Mammal : Animal
    {
        public override string ClassType { get; set; } = "Mammal";
        
        public abstract bool HasRetractableClaws { get; set; }

        public virtual string WhatClassAmI()
        {
            return $"I am a {ClassType}.";
        }
    }
}
