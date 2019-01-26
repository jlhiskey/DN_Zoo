using DN_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DN_Zoo.Classes
{
    /// <summary>
    /// BASE Animal class is the base class. It uses the interfaces IAlive and IEat
    /// </summary>
    public abstract class Animal : IAlive, IEat
    {
        public abstract string SpeciesName { get; set; }
        public abstract string AnimalName { get; set; }
        public abstract int Age { get; set; }
        public abstract string ClassType { get; set; }
        public virtual object Food { get; set; } = WhatIEat();
        public virtual bool HasVenom { get; set; }

        public static object WhatIEat()
        {
            Food defaultFood = new Food
            {
                Name = "Default Food",
                Type = "Default Type"
            };
            return defaultFood;
        }

       
        
        

        public virtual string AmIAlive()
        {
            return "I am an animal.";
        }

        public string Speak()
        {
            Console.WriteLine("Hello I am alive");
            return "Alive";
        }
    }
}
