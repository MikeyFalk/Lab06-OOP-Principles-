using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    public abstract class Animal
    {
        public abstract int Eyes { get; set; }
        public abstract bool Wings { get; set; }
        public abstract int Legs { get; set; }
        public abstract string Diet { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("The animal eats");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("The animal sleeps");

        }

        public virtual void Sound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
}
