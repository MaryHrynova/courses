using System;

namespace Homework1
{

    class Character
    {
        readonly string name;
        bool gender;

        public Character(string name, bool gender)
        {
            this.name = name;
            this.gender = gender;
        }

        public void Cry()
        {
            Console.WriteLine("{0} плачет.", name);
        }
        public virtual bool IsAlzheimer()
        {
            return false;
        }
        public virtual bool Breaking(bool alzheimer)
        {
            if (alzheimer)
                Console.WriteLine("{0} бил-бил, не разбил.", name);
            else
                Console.WriteLine("{0} бил-бил, и разбил)))", name);
            return false;
        }

        class Chiken : Character
        {
            public Chiken(string name, bool gender) : base(name, gender)
            {

            }
             public void LaidEgg()
            {
                if (this.gender == true)
                    System.Console.WriteLine("Снесла курочка яичко, да не простое, а золотое.");
                else
                    Console.WriteLine("Петухи яиц не несут.");
            }
            public void ToClack()
            {
                System.Console.WriteLine("Не плачь, деда, не плачь, баба, Я снесу вам яичко другое, не золотое, а простое.");
            }

        }

        class Mouse : Character
        {
            public Mouse(string name, bool gender) : base(name, gender) { }
            public override bool Breaking(bool alzheimer)
            {
                Console.WriteLine("{0} бежала, хвостиком махнула, Яичко упало и разбилось.", name);
                return true;
            }
        }

        class Baba : Character
        {
            public Baba(string name, bool gender) : base(name, gender) { }
            public override bool IsAlzheimer()
            {
                Random rnd = new Random();
                if (rnd.Next(0, 100) < 60)
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

        class Ded : Character
        {
            public Ded(string name, bool gender) : base(name, gender) { }

            public override bool IsAlzheimer()
            {
                Random rnd = new Random();
                if (rnd.Next(0, 100) < 70)
                    return true;
                return false;

            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Baba Baba = new Baba("Баба", true);
                Ded Ded = new Ded("Дед", false);
                Chiken Chiken = new Chiken("Ряба", true);
                Mouse Mouse = new Mouse("Мышка", true);


                Console.WriteLine("Жили-были дед и баба и была у них курочка {0}.", Chiken.name);
                Chiken.LaidEgg();
                bool al = Ded.IsAlzheimer();
                Ded.Breaking(al);
                if (al)
                {
                    bool al2 = Baba.IsAlzheimer();
                    Baba.Breaking(al2);
                    if (al2)
                    {
                        bool al3 = Mouse.IsAlzheimer();
                        Mouse.Breaking(al3);
                        Ded.Cry();
                        Baba.Cry();
                        Chiken.ToClack();
                    }
                }       
            }
        }
    }
}
 