using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    class Dragon : Mythical
    {
        public override bool Immortal { get ; set ; }
        public override int Horns { get; set; }
        public override string OriginRealm { get; set; }
        public override int Eyes { get; set; }
        public override int Legs { get; set; }

       public Dragon()
        {
            Immortal = false;
            Horns = 3;
            OriginRealm = "Romania";
            Eyes = 2;
            Legs = 4;
            Wings = true;
            Diet = "Treasure";
        }
        public override string MagicPower()
        {
            return "soul meld";
        }

        public override string Speech()
        {
            return "Can speak ancient languages";
        }

        public override string Eat()
        {
            //Console.WriteLine("A dragon needs to eat a lot of treasure");
            return "A dragon needs to eat a lot of treasure";
        }
    }
}
