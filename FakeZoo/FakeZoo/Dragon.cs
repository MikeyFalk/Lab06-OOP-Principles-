using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    class Dragon : Mythical, ICanFly, ICanBurrow
    {
        public override bool Immortal { get; set; }
        public override int Horns { get; set; }
        public override string OriginRealm { get; set; }
        public override int Eyes { get; set; }
        public override int Legs { get; set; }
        public string How { get; set; }
        public int MaxDistance { get; set; }

        public Dragon()
        {
            Immortal = false;
            Horns = 3;
            OriginRealm = "Romania";
            Eyes = 2;
            Legs = 4;
            Wings = true;
            Diet = "Treasure";
            How = "Large magical wings";
            MaxDistance = 1000;
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

        public string TakeOff()
        {
            return "Ascend into the sky";
        }

        public string Land()
        {
            return "Crash back down to the earth";
        }

        public string Soar()
        {
            return "Soar through the sky, terrifying villagers";
        }

        public string DigDown()
        {
            return "Dragons can dig large burrows for their treasure";
        }

        public string Surface()
        {
            return "Come back to the above world";
        }
    }
}
