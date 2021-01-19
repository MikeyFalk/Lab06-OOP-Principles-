using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    public abstract class OfThisRealm
    {
        public abstract bool Mammal { get; set; }
        public abstract bool Flight { get; set; }

        public abstract void DoSomethingNormal();
    }
}
