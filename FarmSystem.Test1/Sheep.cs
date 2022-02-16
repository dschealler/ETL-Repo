using System;

namespace FarmSystem.Test1
{
    public class Sheep : Animal
    {
        private const string NAME = "Sheep";
        private const string NOISE = "baa!";

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
            Console.WriteLine("Sheep says baa!");
        }
        
        public void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }

}