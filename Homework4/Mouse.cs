using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    class Mouse : Character, IBreak
    {
        public Mouse(string name, bool gender) : base(name, gender) { }
        bool IBreak.Breaking(bool alzheimer)
        {
            Console.WriteLine("{0} бежала, хвостиком махнула, Яичко упало и разбилось.", name);
            return true;
        }

        public override bool IsAlzheimer()
        {
            return false;
        }
    }
}
