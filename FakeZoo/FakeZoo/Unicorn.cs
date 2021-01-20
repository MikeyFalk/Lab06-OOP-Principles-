using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    public class Unicorn : Mythical
    {
        public string ManeColor { get; set; }
        public override bool Immortal { get ; set ; }
        public override int Horns { get; set; }   
        public override string OriginRealm { get; set; }
        public override int Eyes { get; set; }
        public override bool Wings { get; set; }
        public override int Legs { get; set; }
        public override string Diet { get; set; }

    public Unicorn()
        {
            ManeColor = "rainbow";
            Immortal = true;
            Horns = 1;
            OriginRealm = "Rainbowland";
            Eyes = 2;            
            Legs = 4;
            Diet = "Rainbow ice cream";
        }

        public override string MagicPower()
        {
            return "tricks humans";
        }

        public override string Speech()
        {
            return "Very Intelligent";
        }

        public string GrantWishes()
        {
            return "You only get 3 wishes";
        }

        public string PoopRainbows()
        {
            return "Its true! they poop rainbows";
        }
    }
}
