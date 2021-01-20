using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    public class Gryphon : Mythical , ICanFly
    {
        public override bool Immortal { get; set; }
        public override int Horns { get; set; }
        public override string OriginRealm { get; set; }
        public override int Eyes { get; set; }
        public override int Legs { get; set; }

        public string FeatherColor { get; set; }
        public string How { get ; set ; }
        public int MaxDistance { get; set ; }

        public Gryphon()
        {
            FeatherColor = "Emerald Green";
            Immortal = false;
            Horns = 0;
            OriginRealm = "Egypt";
            Eyes = 2;
            Legs = 4;
            Wings = true;
            Diet = "arugula";
            How = "Magical eagles wings";
            MaxDistance = 111;


         }
       

       
        public override string MagicPower()
        {
            return "can disappear at will";
        }

        public override string Speech()
        {
            return "speaks only in riddles";
        }

        public void LayGoldenEgg()
        {
            Console.WriteLine("The Gryphon will lay a golden egg every 10 years");
        }

        public string TakeOff()
        {
            return "With thrashing feathered wings the Gryphon ascends";
        }

        public string Land()
        {
            return "Lands at the nearest flight path";
        }

        public string Soar()
        {
            return "Soars the skys with the grace of a bird and.. catness of a lion.";
        }
    }
}
