using System;

namespace Homework1
{
        class Program
        {
            static void Main(string[] args)
            {
                Grandma Grandma = new Grandma("Баба", true);
                Grandpa Grandpa = new Grandpa("Дед", false);
                Chiken Chiken = new Chiken("Ряба", true);
                Mouse Mouse = new Mouse("Мышка", true);

                Story.Start(Grandpa.name, Grandma.name, Chiken.name);
                Story.MainHeroOfThisStory<Grandma>(Grandma);
                int type = Randomizer.rnd.Next(1, 4);
                
            try
            {
                Chiken.LaidEgg += Chiken.Display;
                Chiken.LaidingEgg(type);
                bool al = Grandpa.IsAlzheimer();
                ((IBreak)Grandpa).Breaking(al);
                if (al)
                {
                    bool al2 = Grandma.IsAlzheimer();
                    ((IBreak)Grandma).Breaking(al2);
                    if (al2)
                    {
                        bool al3 = Mouse.IsAlzheimer();
                        ((IBreak)Mouse).Breaking(al3);
                        Grandpa.Cry();
                        Grandma.Cry();
                        Chiken.ToClack(type);
                    }
                }
            }
            catch (SomethingWrongWithEgg ex)
            {
                Console.WriteLine(ex.Message);
                Grandpa.DoNotTouch();
                Grandma.DoNotTouch();
            }
            finally
            {
                Story.End();
            }
                
            }
        }
}
 