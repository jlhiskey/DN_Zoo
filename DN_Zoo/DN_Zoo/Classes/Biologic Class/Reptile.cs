using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Biologic_Class
{
    /// <summary>
    /// ABSTRACT Reptile class inheretes the properties of the Base Class Animal.
    /// </summary>
    public abstract class Reptile : Animal
    {
        public override string ClassType { get; set; } = "Reptile";

        public abstract bool CanSwim { get; set; }
        

        public virtual string WhatClassAmI()
        {
            return $"I am a {ClassType}.";
        }
    }
}
