using FarmSystem.Test2;
using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private List<Animal> _animals = new List<Animal>();

        //TEST 1
        public void Enter(Animal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            this._animals.Add(animal);
            Console.WriteLine(this.EnterLine(animal));
        }

        public string EnterLine(Animal animal)
        {
            return $"{animal.Name} has entered the farm";
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            if (this._animals.Count == 0)
            {
                Console.WriteLine("There are no animals in the farm");
            }
            else
            {
                foreach(var animal in this._animals)
                {
                    Console.WriteLine(animal.MakeNoise());
                }
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            if (this._animals.Count == 0)
            {
                Console.WriteLine("There are no animals in the farm");
            }
            else
            {
                foreach (var animal in this._animals)
                {
                    var milkableAnimal = animal as IMilkableAnimal;
                    if (milkableAnimal == null)
                        continue;

                    milkableAnimal.ProduceMilk();
                }
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
           Console.WriteLine("There are still animals in the farm, farm is not free");
        }
    }
}