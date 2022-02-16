using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal, IMilkableAnimal
    {
        private const string NAME = "Cow";
        private const string NOISE = "Moo!";

        public override string Name => NAME;
        public override string Noise => NOISE;

        public Cow()
        {
            this.NoOfLegs = 4;
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