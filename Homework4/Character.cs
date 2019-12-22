using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    public abstract class Character
    {
        public string name;
        protected bool gender;
        public delegate void CharacterAction(string action);
        event CharacterAction Notify;
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
        
        public virtual void DoNotTouch()
        {
            Console.WriteLine($"{name} не стал трогать это яйцо.");
        }
    }
}
