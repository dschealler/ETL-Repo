namespace FarmSystem.Test1
{
    public class Sheep : Animal
    {
        private const string NAME = "Sheep";
        private const string NOISE = "baa!";

        public override string Name => NAME;
        public override string Noise => NOISE;

        public Sheep()
        {
            this.NoOfLegs = 4;
        }
    }

}