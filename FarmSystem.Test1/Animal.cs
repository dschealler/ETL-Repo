using FarmSystem.Test2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    public abstract class Animal
    {
        public virtual string Name { get; }
        public virtual string Noise { get; }

        public string MakeNoise()
        {
            return $"{this.Name} says {this.Noise}";
        }

        public bool IsMilkable()
        {
            throw new NotImplementedException();
        }

        public string Milk()
        {
            throw new NotImplementedException();
        }
    }
}
