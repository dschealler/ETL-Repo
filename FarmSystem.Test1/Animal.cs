using System;

namespace FarmSystem.Test1
{
    public abstract class Animal
    {
        public abstract string Name { get; }
        public abstract string Noise { get; }

        protected Guid _id = Guid.NewGuid();
        public string Id { get { return this._id.ToString(); } }

        public int NoOfLegs { get; set; }

        public string TalkLine()
        {
            return $"{this.Name} says {this.Noise}";
        }

        public void Talk()
        {
            Console.WriteLine(this.TalkLine());
        }

        public string WalkLine()
        {
            return $"{this.Name} is walking";
        }

        public void Walk()
        {
            Console.WriteLine(this.WalkLine());
        }

        public string RunLine()
        {
            return $"{this.Name} is running";
        }

        public void Run()
        {
            Console.WriteLine(this.RunLine());
        }
    }
}
