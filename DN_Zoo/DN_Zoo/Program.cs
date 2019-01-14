using System;
using DN_Zoo.Classes;
using DN_Zoo.Classes.Animals;

namespace DN_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseCat gregor = new HouseCat();
            gregor.AnimalName = "Gregor";
            gregor.Age = 5;
            Console.WriteLine(gregor.AmIAlive());
            Console.WriteLine(gregor.WhatClassAmI());
            Console.WriteLine(gregor.WhatIsMySubtype());
            Console.WriteLine(gregor.Speak());


            Console.ReadLine();
        }
    }
}
