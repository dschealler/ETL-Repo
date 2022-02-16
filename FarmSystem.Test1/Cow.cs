using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal, IMilkableAnimal
    {
        private const string NAME = "Cow";
        private const string NOISE = "Moo!";
        private const int DEFAULT_NO_OF_LEGS = 2;

        public override string Name => NAME;
        public override string Noise => NOISE;

        public Cow()
        {
            this.NoOfLegs = DEFAULT_NO_OF_LEGS;
        }

        public void ProduceMilk()
        {
            Console.WriteLine(this.ProduceMilkLine());
        }

        public string ProduceMilkLine()
        {
            return $"{this.Name} was milked!";
        }
    }
}