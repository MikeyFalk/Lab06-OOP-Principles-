using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    public abstract class Mythical : Animal
    {
        public abstract bool Immortal { get; set; }
        public abstract int Horns { get; set; }
        public abstract string OriginRealm { get; set; }

        public abstract void MagicPower();
        public abstract void Speech();

        

    }
}
