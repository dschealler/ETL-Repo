using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal, IMilkableAnimal
    {
        private const string NAME = "Cow";
        private const string NOISE = "Moo!";

        private string _id;
        private int _noOfLegs = 4;

        public override string Name => NAME;
        public override string Noise => NOISE;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }

        public void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void Run()
        {
            Console.WriteLine("Cow is running");
        }

        public string ProduceMilkLine()
        {
            return $"{this.Name} was milked!";
        }

        public void ProduceMilk()
        {
            Console.WriteLine(this.ProduceMilkLine());
        }
    }
}