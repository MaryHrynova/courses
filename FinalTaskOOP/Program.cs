using System;

namespace FinalTaskOOP
{
    class Program
    {
        public static void Space()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }
        static void Main(string[] args)
        {
            FootballPlayer P1 = new FootballPlayer("Black", 30);
            FootballPlayer P2 = new FootballPlayer("Herasim", 31);
            FootballPlayer P3 = new FootballPlayer("Ilchenko", 25);
            FootballPlayer P4 = new FootballPlayer("Rudchenko", 19);
            FootballPlayer P5 = new FootballPlayer("Flop", 32);
            FootballPlayer P6 = new FootballPlayer("Noize", 33);

            Couch C1 = new Couch("Daniels");
            Couch C2 = new Couch("Blablabla");

            Team first = new Team("First", C1);
            Team second = new Team("Second", C2);

            Refery Donut = new Refery("Donut");

            first.Add(P1);
            first.Add(P2);
            first.Add(P3);

            Space();

            second.Add(P4);
            second.Add(P5);
            second.Add(P6);

            Space();

            first.Display();

            Space();

            second.Display();

            Space();

            Game game = new Game(first, second, Donut);
            game.Goal += Refery.GoalDisplay;
            game.Violation += Refery.ViolatingDisplay;

            game.Start();
            
        }
    }
}
