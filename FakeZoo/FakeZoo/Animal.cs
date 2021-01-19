using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    public abstract class Animal
    {
        public abstract int Eyes { get; set; }
        public virtual bool Wings { get; set; } = false;
        public abstract int Legs { get; set; }
        public virtual string Diet { get; set; } = "food";

        public virtual string Eat()
        {
            //Console.WriteLine("The animal eats");
            return "The animal eats";
        }

        public virtual string Sleep()
        {
            return "The animal sleeps";

        }

        public virtual string Sound()
        {
            return "The animal makes a sound";
        }
    }
}
