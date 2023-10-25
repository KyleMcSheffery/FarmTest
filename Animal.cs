using System;

namespace FarmSystem.Test1
{
    public class Animal 
    {
        public string AnimalNoise { get; set; } = "";
        public string AnimalType { get; set; } = "";

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public int NoOfLegs { get; set; }

        // Write the animal's noise to the console
        public void Talk()
        {
            Console.WriteLine(AnimalType + " says " + AnimalNoise + "!");
        }

        public void Walk()
        {
            Console.WriteLine(AnimalType + " is walking");
        }

        public void Run()
        {
            Console.WriteLine(AnimalType + " is running");
        }
    }
}