using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTaskOOP
{
    class FootballPlayer
    {
        public string Surname;
        public int Age;
        public int Master = Randomizer.rnd.Next(100);

        public FootballPlayer(string surname, int age)
        {
            this.Age = age;
            this.Surname = surname;
        }
    }
}
