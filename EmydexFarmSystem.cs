using System;
using System.Collections.Generic;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        Queue<Animal> farmAnimals = new Queue<Animal>();
        public event EventHandler FarmEmpty = delegate { };

        //TEST 1
        public void Enter(Animal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities

            farmAnimals.Enqueue(animal);
            Console.WriteLine(animal.AnimalType + " has entered the Emydex farm");
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk

            if (farmAnimals.Count > 0)
            {
                foreach(Animal a in farmAnimals)
                {
                    a.Talk();
                }
            }
            else
            {
                Console.WriteLine("There are no animals in the farm");
            }
            
        }

        //TEST 3
        public void MilkAnimals()
        {
            if (farmAnimals.Count > 0)
            {
                foreach(Animal animal in farmAnimals)
                {
                    if (animal is IMilkableAnimal milkableAnimal)
                    {
                        milkableAnimal.ProduceMilk();
                    }
                }
            }
            else
            {
                Console.WriteLine("There are no animals in the farm");
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            // While there are animals in the farm
            while(farmAnimals.Count > 0)
            {
                // Remove an animal from the farm (first in first out)
                RemoveAnimal();
            } 
        }

        public void RemoveAnimal()
        {
            // Remove the next farm animal from the queue
            Console.WriteLine(farmAnimals.Dequeue().AnimalType + " has left the farm");

            // Check if the farm is empty
            if(farmAnimals.Count == 0)
            {
                FarmEmpty?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}