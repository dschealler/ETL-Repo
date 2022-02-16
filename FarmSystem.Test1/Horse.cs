namespace FarmSystem.Test1
{
    public class Horse : Animal
    {
        private const string NAME = "Horse";
        private const string NOISE = "Neigh!";
        private const int DEFAULT_NO_OF_LEGS = 4;

        public override string Name => NAME;
        public override string Noise => NOISE;

        public Horse()
        {
            this.NoOfLegs = DEFAULT_NO_OF_LEGS;
        }
    }
}