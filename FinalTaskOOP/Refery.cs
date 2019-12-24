using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTaskOOP
{
    public enum HonestRefery
    {
        ok = 1,
        preferFirst = 2,
        preferSecond = 3,
    };
    class Refery
    {
        public string Surname;
        public HonestRefery Honest = (HonestRefery)Randomizer.rnd.Next(1, 3); // get his prefers randomly

        public Refery(string name)
        {
            Surname = name;
        }

        public static void GoalDisplay(FootballPlayer fp)
        {
            Console.WriteLine($"{fp.Surname} scores a goal!");
        }

        public static void ViolatingDisplay(FootballPlayer fp)
        {
            Console.WriteLine($"{fp.Surname} breaks the rules!");
        }

    }
}
