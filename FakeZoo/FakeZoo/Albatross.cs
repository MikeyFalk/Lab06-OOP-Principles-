using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    class Albatross : OfThisRealm , ICanFly
    {
        public override bool Mammal { get ; set ; }
        public override int Eyes { get ; set ; }
        public override int Legs { get ; set; }
        public override bool Wings { get; set; }
        public override bool WebbedFeet { get; set; }
        public bool Enormous { get; set; }
        public int Wingspan { get; set; }
        public string How { get; set ; }
        public int MaxDistance { get ; set ; }

        public Albatross()
        {
            Mammal = false;
            Eyes = 2;
            Legs = 2;
            Wings = true;
            WebbedFeet = true;
            Enormous = true;
            Wingspan = 10;
            How = "regular wings";
            MaxDistance = 3000;

        }

        public override string DoSomethingNormal()
        {
            return "inspire an Iron Maiden song";
        }

        public string SquakYourEarsOff()
        {
            return "Now you're deaf!";
        }

        public string TakeOff()
        {
            return "I'm usually flying anyway";
        }

        public string Land()
        {
            return "I land some times";
        }

        public string Soar()
        {
            return "Drifting above the ocean sky";
        }
    }
}
