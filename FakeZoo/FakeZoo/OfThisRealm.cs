using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    public abstract class OfThisRealm : Animal
    {
        public abstract bool Mammal { get; set; }
        public abstract bool Flight { get; set; }

        public abstract string DoSomethingNormal();
    }
}
