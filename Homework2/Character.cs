using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    abstract class Character
    {
        public string name;
        protected bool gender;

        public Character(string name, bool gender)
        {
            this.name = name;
            this.gender = gender;
        }

        public void Cry()
        {
            Console.WriteLine("{0} плачет.", name);
        }
        abstract public bool IsAlzheimer();
        public virtual bool Breaking(bool alzheimer)
        {
            if (alzheimer)
                Console.WriteLine("{0} бил-бил, не разбил.", name);
            else
                Console.WriteLine("{0} бил-бил, и разбил)))", name);
            return false;
        }
    }
}
