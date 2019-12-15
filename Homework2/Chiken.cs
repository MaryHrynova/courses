using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    enum Egg
    {
       Simple = 1,
       Gold = 2,
       Shit = 3,
    }
    class Chiken : Character
    {
        public Chiken(string name, bool gender) : base(name, gender) { }
        public StringBuilder egg = new StringBuilder("");
        public override bool IsAlzheimer()
        {
            return false;
        }

        public void LaidEgg(int type)
        {
            if (this.gender != true)
                Console.WriteLine("Петухи яиц не несут.");
            else
            {
                
                switch (type)
                {
                    case 1: egg.Append("простое"); break;
                    case 2: egg.Append("золотое"); break;
                    case 3:
                        {   egg.Append("дерьмо какое-то");
                            throw new Exception ("Это не яйцо!");
                        }

                    case 4:
                        {
                            egg.Append("гнилое");
                            throw new Exception("Гнилое яйцо!");
                        }


                            default: throw new Exception("Черти-что, а не яйцо");
                }
                if(egg.ToString() != "простое")
                    System.Console.WriteLine($"Снесла курочка яичко, да не простое, а {egg}.");
                else
                    System.Console.WriteLine($"Снесла курочка яичко.");
            }
                
        }
        public void ToClack()
        {
            if (egg.ToString() != "простое")
                System.Console.WriteLine($"Не плачь, деда, не плачь, баба, Я снесу вам яичко другое, не {egg}, а простое.");
            else
                System.Console.WriteLine($"Не плачь, деда, не плачь, баба, Я снесу вам яичко другое.");
        }

    }
}
