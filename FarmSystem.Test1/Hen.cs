namespace FarmSystem.Test1
{
    public class Hen : Animal
    {
        private const string NAME = "Hen";
        private const string NOISE = "CLUCKAAAAAWWWWK!";

        public override string Name => NAME;
        public override string Noise => NOISE;

        public Hen()
        {
            this.NoOfLegs = 2;
        }
    }
}