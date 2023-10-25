using System;

namespace FarmSystem.Test1
{
    public class Horse : Animal
    {
        public Horse ()
        {
            AnimalType = "Horse";
            AnimalNoise = "Neigh";
            NoOfLegs = 4;
        }
    }
}