using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    public abstract class OfThisRealm : Animal
    {
        public abstract bool Mammal { get; set; }
        public virtual bool WebbedFeet { get; set; } = false;

        public abstract string DoSomethingNormal();
    }
}
