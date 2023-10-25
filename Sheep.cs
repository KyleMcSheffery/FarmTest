using System;

namespace FarmSystem.Test1
{
    public class Sheep : Animal
    {
        public Sheep ()
        {
            AnimalType = "Sheep";
            AnimalNoise = "Baa";
            NoOfLegs = 4;
        }
    }
}