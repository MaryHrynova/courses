using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    class Grandma : Character
    {
        public Grandma(string name, bool gender) : base(name, gender) { }
        public override bool IsAlzheimer()
        {
            if (Randomizer.rnd.Next(0, 100) < 60)
                return true;
            return false;
        }
        public override bool Breaking(bool alzheimer)
        {
            
            if (alzheimer)
            {
                Console.WriteLine("{0} била-била, не разбила.", name);
                return false;
            }
            else
            {
                Console.WriteLine("{0} била-била, и разбила.", name);
                return true;
            }

        }
    }
}
