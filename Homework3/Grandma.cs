using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    class Grandma : Character, IBreak
    {
        public Grandma(string name, bool gender) : base(name, gender) { }
        public override bool IsAlzheimer()
        {
            if (Randomizer.rnd.Next(0, 100) < 60)
                return true;
            return false;
        }
        

        bool IBreak.Breaking(bool alzheimer)
        {
            if (alzheimer)
            {
                Console.WriteLine("{0} била-била, не разбила.", name);
                return false;
            }
            else
            {
                Console.WriteLine("{0} била-била, и разбила!", name);
                return true;
            }
        }
        public override void DoNotTouch()
        {
            Console.WriteLine($"{name} не стала трогать это яйцо.");
        }
    }
}
