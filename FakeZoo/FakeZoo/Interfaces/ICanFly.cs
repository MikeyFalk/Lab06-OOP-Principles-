using System;
using System.Collections.Generic;
using System.Text;

namespace FakeZoo
{
    interface ICanFly
    {
        string How { get; set; }
        int MaxDistance { get; set; }

        string TakeOff();
        string Land();
        string Soar();

    }
}
