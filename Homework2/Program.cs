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


                Console.WriteLine("Жили-были дед и баба и была у них курочка {0}.", Chiken.name);
                int type = Randomizer.rnd.Next(1, 5);
            try
            {
                Chiken.LaidEgg(type);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Снесла курочка яичко, да не простое, а {Chiken.egg}.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                bool al = Grandpa.IsAlzheimer();
                Grandpa.Breaking(al);
                if (al)
                {
                    bool al2 = Grandma.IsAlzheimer();
                    Grandma.Breaking(al2);
                    if (al2)
                    {
                        bool al3 = Mouse.IsAlzheimer();
                        Mouse.Breaking(al3);
                        Grandpa.Cry();
                        Grandma.Cry();
                        Chiken.ToClack();
                    }
                }
            }
                
            }
        }
}
 