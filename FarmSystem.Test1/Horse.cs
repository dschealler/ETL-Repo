using System;

namespace FarmSystem.Test1
{
    public class Horse : Animal
    {
        private const string NAME = "Horse";
        private const string NOISE = "Neigh!";

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
            Console.WriteLine("Horse says neigh!");
        }

        public void Run()
        {
            Console.WriteLine("Horse is running");
        }
        
    }
}