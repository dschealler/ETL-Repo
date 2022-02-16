namespace FarmSystem.Test1
{
    public class Hen : Animal
    {
        private const string NAME = "Hen";
        private const string NOISE = "CLUCKAAAAAWWWWK!";
        private const int DEFAULT_NO_OF_LEGS = 2;

        public override string Name => NAME;
        public override string Noise => NOISE;

        public Hen()
        {
            this.NoOfLegs = DEFAULT_NO_OF_LEGS;
        }
    }
}