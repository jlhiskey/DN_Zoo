using DN_Zoo.Classes.Biologic_Class;
using DN_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes.Biologic_Class_Sub_Types
{
    /// <summary>
    /// ABSTRACT Canine class inheretes the properties of the Biologic Class Mammal and uses the interfaces IBite and overrides default interface IEat.
    /// </summary>
    public abstract class Canine : Mammal, IBite, IEat
    {
        public override bool HasRetractableClaws { get; set; } = false;

        public abstract bool CanBeDomesticated { get; set; }

        public static new object WhatIEat()
        {
            Food meat = new Food
            {
                Name = "Red Meat",
                Type = "Carnivore"
            };
            return meat;
        }

        public override object Food { get; set; } = WhatIEat();
        
        public virtual string Bite()
        {
            Console.WriteLine("Wear gloves I bite.");
            return "Bite";
        }

        public virtual string WhatIsMySubtype()
        {
            return "I am a Canine.";
        }

    }
}
