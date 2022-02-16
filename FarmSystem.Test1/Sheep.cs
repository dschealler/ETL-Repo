namespace FarmSystem.Test1
{
    public class Sheep : Animal
    {
        private const string NAME = "Sheep";
        private const string NOISE = "baa!";
        private const int DEFAULT_NO_OF_LEGS = 4;

        public override string Name => NAME;
        public override string Noise => NOISE;

        public Sheep()
        {
            this.NoOfLegs = DEFAULT_NO_OF_LEGS;
        }
    }

}