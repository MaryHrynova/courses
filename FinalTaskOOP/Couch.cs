using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTaskOOP
{
    class Couch
    {
        public string Surname;
        public double Success = Randomizer.rnd.NextDouble() + 0.5;

        public Couch(string name)
        {
            this.Surname = name;
        }
    }
}
