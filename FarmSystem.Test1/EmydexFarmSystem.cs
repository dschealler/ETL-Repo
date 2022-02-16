using FarmSystem.Test2;
using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private readonly Queue<Animal> _animals = new Queue<Animal>();

        //TEST 1
        public void Enter(Animal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            this._animals.Enqueue(animal);
            Console.WriteLine(this.EnterLine(animal));
        }

        public string EnterLine(Animal animal)
        {
            return $"{animal.Name} has entered the farm";
        }

        public string LeaveLine(Animal animal)
        {
            return $"{animal.Name} has left the farm";
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
                    animal.Talk();
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
                    if (animal is IMilkableAnimal milkableAnimal)
                    {
                        milkableAnimal.ProduceMilk();
                    }
                }
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            if (this._animals.Count == 0)
            {
                Console.WriteLine("There are no animals in the farm");
            }
            else
            {
                while (this._animals.Count >= 1)
                {
                    var animal = this._animals.Dequeue();
                    Console.WriteLine(this.LeaveLine(animal));
                }

                EventArgs e = new EventArgs();
                this.OnFarmEmpty(e);
            }
        }

        public event EventHandler FarmEmpty;
        protected virtual void OnFarmEmpty(EventArgs e)
        {
            var handler = this.FarmEmpty;
            handler?.Invoke(this, e);
        }
    }
}