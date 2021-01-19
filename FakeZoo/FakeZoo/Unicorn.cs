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
            Wings = false;
            Legs = 4;
            Diet = "Rainbow ice cream";
        }

        public override void MagicPower()
        {
            
            Console.WriteLine("tricks humans");
        }

        public override void Speech()
        {
            Console.WriteLine("Very Intelligent");
        }

        public void GrantWishes()
        {
            Console.WriteLine("You only get 3 wishes");
        }

        public void PoopRainbows()
        {
            Console.WriteLine("Its true! they poop rainbows");
        }
    }
}
