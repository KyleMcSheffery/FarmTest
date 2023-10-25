using System;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
    public class Cow : Animal, IMilkableAnimal
    {
        public Cow ()
        {
            AnimalType = "Cow";
            AnimalNoise = "Moo";
            NoOfLegs = 4;
        }

        // Milk the cow and write to the console
        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }
    }
}