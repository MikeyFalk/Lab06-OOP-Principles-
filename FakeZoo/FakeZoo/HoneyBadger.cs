using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    class HoneyBadger : OfThisRealm
    {
        public override bool Mammal { get; set; }
        public override bool Flight { get; set; }
        public override int Eyes { get; set; }
        public override int Legs { get; set; }
        public int F_cks_Given { get; set; }

        public HoneyBadger()
        {
            Mammal = true;
            Flight = false;
            Eyes = 2;
            Legs = 4;
            Wings = false;
            Diet = "Cobra's, they don't care";
            F_cks_Given = 0;
        }

        public override string DoSomethingNormal()
        {
            return "Do some normal earthly creature stuff";
        }
      
        public override string Eat()
        {
            return "Honey Badgers eat everything";
        }

        public string Dont_Give_A_F_CK()
        {
            return "Honey Badger just don't care";
        }
    }
}
