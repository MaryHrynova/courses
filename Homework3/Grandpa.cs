using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    class Grandpa : Character, IBreak
    {
        public Grandpa(string name, bool gender) : base(name, gender) { }

        public override bool IsAlzheimer()
        {
            if (Randomizer.rnd.Next(0, 100) < 70)
                return true;
            return false;

        }
      
        bool IBreak.Breaking(bool alzheimer)
        {
            if (alzheimer)
                Console.WriteLine("{0} бил-бил, не разбил.", name);
            else
                Console.WriteLine("{0} бил-бил, и разбил!", name);
            return false;
        }
    }
}
