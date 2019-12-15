using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    class Grandpa : Character
    {
        public Grandpa(string name, bool gender) : base(name, gender) { }

        public override bool IsAlzheimer()
        {
            if (Randomizer.rnd.Next(0, 100) < 70)
                return true;
            return false;

        }
    }
}
