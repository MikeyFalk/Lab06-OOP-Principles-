using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    public class Wombat : OfThisRealm , ICanBurrow
    {
        public override bool Mammal { get; set; }
        public override int Legs { get; set; }
        public override int Eyes { get; set; }
        public bool HasPouch { get; set; }

        public Wombat()
        {
            Mammal = true;
            Legs = 2;
            Eyes = 2;
            HasPouch = true;
        }


        public override string DoSomethingNormal()
        {
            return "Wombats carry their new born babies in a pouch";

        }
        public override string Eat()
        {
            return "Wombats eat veggimite sandwiches";
        }
        public override string Sound()
        {
            return "Wombats purr like cats";
        }

        public string PoopsCubes()
        {
            return "Wombat dung is shaped like a cube and no one knows why";
        }

        public string DigDown()
        {
            return "Wombats are great at burrowing and even share their burrows with other animals";
        }

        public string Surface()
        {
            return "Pop up for some sunlight";
        }
    }
}
