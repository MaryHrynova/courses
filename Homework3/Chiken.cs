using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    public class Eggs : List<string>
    {
        public static List<string> eggs = new List<string> {"простое", "золотое", "гнилое", "битое"};
    }
    class Chiken : Character
    {
        public Chiken(string name, bool gender) : base(name, gender) { }
        
        public delegate void Laid(int type);
        public event Laid LaidEgg;
        public override bool IsAlzheimer()
        {
            return false;
        }

        public void LaidingEgg(int type)
        {
            if (this.gender != true)
                Console.WriteLine("Петухи яиц не несут.");
            else
            {
                
                switch (type)
                {
                    case 1: LaidEgg?.Invoke(1); break;
                    case 2: LaidEgg?.Invoke(2); break;
                    case 3:
                            LaidEgg?.Invoke(3); throw new SomethingWrongWithEgg("Кажется, яйцо испортилось...");
                    case 4:
                            LaidEgg?.Invoke(4); throw new SomethingWrongWithEgg("Битое яйцо!");
                            
                    default: throw new SomethingWrongWithEgg("Черти-что, а не яйцо");
                }
                
            }
                
        }
        public void Display(int type)
        {

            if (Eggs.eggs[type] != "простое")
                System.Console.WriteLine($"Снесла курочка яичко, да не простое, а {Eggs.eggs[type]}.");
            else
                System.Console.WriteLine($"Снесла курочка яичко.");
        }
        public void ToClack(int type)
        {
            if (type.ToString() != "простое")
                System.Console.WriteLine($"Не плачь, деда, не плачь, баба, Я снесу вам яичко другое, не {Eggs.eggs[type]}, а простое.");
            else
                System.Console.WriteLine($"Не плачь, деда, не плачь, баба, Я снесу вам яичко другое.");
        }

    }
}
