namespace FarmSystem.Test1
{
    public class Horse : Animal
    {
        private const string NAME = "Horse";
        private const string NOISE = "Neigh!";

        public override string Name => NAME;
        public override string Noise => NOISE;

        public Horse()
        {
            this.NoOfLegs = 4;
        }
    }
}